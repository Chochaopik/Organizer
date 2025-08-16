using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace Organizer {
    public partial class Form1 : Form {

        #region Gestion fenetres & Hook clavier
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        private static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private string GetWindowText(IntPtr hWnd) {
            StringBuilder sb = new StringBuilder(256);
            GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }


        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private IntPtr hookId = IntPtr.Zero;
        private LowLevelKeyboardProc proc;

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        [DllImport("kernel32.dll")]
        static extern uint GetCurrentThreadId();

        [DllImport("user32.dll")]
        static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public void BringToFront(IntPtr hWnd) {
            if (IsIconic(hWnd)) ShowWindow(hWnd, SW_RESTORE);

            uint threadId = GetWindowThreadProcessId(GetForegroundWindow(), out _);
            uint targetThreadId = GetWindowThreadProcessId(hWnd, out _);
            uint currentThreadId = GetCurrentThreadId();

            AttachThreadInput(currentThreadId, targetThreadId, true);
            AttachThreadInput(threadId, targetThreadId, true);

            SetForegroundWindow(hWnd);

            AttachThreadInput(currentThreadId, targetThreadId, false);
            AttachThreadInput(threadId, targetThreadId, false);
        }

        public void Start() {
            proc = HookCallback;
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule) {
                hookId = SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private int indexActuel = 0;
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN) {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;

                if (Config.checks.Count != 0 || !Config.pause) {
                    if (Config.raccourcis.Contains(key)) {
                        int getIndex = Config.raccourcis.IndexOf(key);
                        if (getIndex == 16) {
                            indexActuel--;
                            if (indexActuel < 0) indexActuel = Config.checks.Count - 1;
                        } else if (getIndex == 17) {
                            indexActuel++;
                            if (indexActuel > Config.checks.Count - 1) indexActuel = 0;
                        } else if (getIndex < 16) {
                            if (getIndex > Config.checks.Count - 1) return CallNextHookEx(hookId, nCode, wParam, lParam);
                            indexActuel = getIndex;
                        } else {
                            return CallNextHookEx(hookId, nCode, wParam, lParam);
                        }
                        Config.form.BringToFront(Config.checks[indexActuel].hWnd);
                    }
                }
            }
            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        public void Stop() {
            UnhookWindowsHookEx(hookId);
        }
        #endregion

        public Form1() {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            Config.form = this;
            Config.chargerRaccourcis();
            refreshList();
            Visible = true;
            ShowInTaskbar = true;
            Opacity = 1;
            Activate();

            Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (Config.attente && Config.btn != null) {
                int index = int.Parse(Config.btn.Name.Replace("btnfen", "")) - 1;
                Config.raccourcis[index] = keyData;
                Config.btn.Text = keyData.ToString();
                Config.btn = null;
                Config.attente = false;
                Config.attenteId = -1;
                Config.sauvegarderRaccourcis();

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            refreshList();
        }

        private void button1_Click(object sender, EventArgs e) {
            checkedListBox1.Items.Clear();
            Config.fenetres.Clear();
            Config.checks.Clear();
            listView1.Items.Clear();

            EnumWindows(delegate (IntPtr hWnd, IntPtr lParam) {
                if (IsWindowVisible(hWnd)) {
                    uint pid;
                    GetWindowThreadProcessId(hWnd, out pid);

                    try {
                        Process proc = Process.GetProcessById((int)pid);
                        string nomProcessus = proc.ProcessName + ".exe";
                        if (nomProcessus.ToLower().Equals(textBox1.Text.ToLower())) {
                            string nom = GetWindowText(hWnd);
                            checkedListBox1.Items.Add(nomProcessus + " | " + nom);
                            listView1.Items.Add("");
                            Config.fenetres.Add(new Fenetre {
                                hWnd = hWnd,
                                proc = nomProcessus,
                                text = nom
                            });
                        }
                    } catch {
                    }
                }
                return true;
            }, IntPtr.Zero);

        }
        private void refreshList() {
            checkedListBox1.Items.Clear();
            Config.fenetres.Clear();
            Config.checks.Clear();
            listView1.Items.Clear();

            EnumWindows(delegate (IntPtr hWnd, IntPtr lParam) {
                if (IsWindowVisible(hWnd)) {
                    uint pid;
                    GetWindowThreadProcessId(hWnd, out pid);

                    try {
                        Process proc = Process.GetProcessById((int)pid);
                        string nomProcessus = proc.ProcessName + ".exe";
                        if (!nomProcessus.Equals("explorer.exe")) {
                            string nom = GetWindowText(hWnd);
                            checkedListBox1.Items.Add(nomProcessus + " | " + nom);
                            listView1.Items.Add("");
                            Config.fenetres.Add(new Fenetre {
                                hWnd = hWnd,
                                proc = nomProcessus,
                                text = nom
                            });
                        }
                    } catch {
                    }
                }
                return true;
            }, IntPtr.Zero);
        }

        private void btnfen_Click(object sender, EventArgs e) {
            Config.putBtn(sender as Button);
        }

        private void fenhov(object sender, EventArgs e) {
            Label lbl = sender as Label;
            if (lbl == null) return;
            int numero = int.Parse(lbl.Name.Replace("label", "")) - 1;

            if (Config.checks.Count - 1 >= numero && Config.checks.Count > 0) {
                Fenetre fen = Config.checks[numero];
                toolTip1.SetToolTip(lbl, fen.proc + "\n" + fen.text);
            } else {
                toolTip1.SetToolTip(lbl, "Aucune fenêtre");
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) {
            string itemTexte = checkedListBox1.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked) {
                if (Config.checks.Count < 16) {
                    Config.checks.Add(Config.fenetres[e.Index]);
                    listView1.Items[e.Index].Text = Config.checks.Count.ToString();
                } else e.NewValue = CheckState.Unchecked;
            } else if (e.NewValue == CheckState.Unchecked) {
                Config.checks.Remove(Config.fenetres[e.Index]);
                listView1.Items[e.Index].Text = "";
                MettreAJourNumeros();
            }
        }
        private void MettreAJourNumeros() {
            for (int i = 0; i < Config.fenetres.Count; i++) {
                Fenetre f = Config.fenetres[i];
                ListViewItem item = listView1.Items[i];

                int indexDansChecks = Config.checks.IndexOf(f);
                if (indexDansChecks != -1) {
                    item.Text = (indexDansChecks + 1).ToString();
                } else {
                    item.Text = "";
                }
            }
        }

        private void btnLostFocus(object sender, EventArgs e) {
            Config.outBtn(sender as Button);
        }

        public void renBtn(string nom, string texte) {
            Control[] controles = Controls.Find(nom, true); // Recherche récursive
            if (controles.Length > 0 && controles[0] is Button btn) {
                btn.Text = texte;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e) {
            if ((e as MouseEventArgs).Button == MouseButtons.Left) {
                if (Visible) {
                    Visible = false;
                    Opacity = 0;
                    ShowInTaskbar = false;
                } else {
                    Visible = true;
                    ShowInTaskbar = true;
                    Opacity = 1;
                    Activate();
                }
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e) {
            Config.pause = !Config.pause;
            if (Config.pause) {
                notifyIcon1.Text = "Organizer - En pause";
                notifyIcon1.Icon = Properties.Resources.icon_disable;
            } else {
                notifyIcon1.Text = "Organizer - En cours d'excution";
                notifyIcon1.Icon = Properties.Resources.icon;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e) {
            Stop();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Stop();
        }
    }
}
