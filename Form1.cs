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

        #region Gestion fenetres
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

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        public void BringToFront(IntPtr hWnd) {
            if (IsIconic(hWnd)) ShowWindow(hWnd, SW_RESTORE);

            SetForegroundWindow(hWnd);
        }
        #endregion

        RaccourciManager racMan = new RaccourciManager();

        public Form1() {
            InitializeComponent();
            Config.form = this;
            Config.chargerRaccourcis();
            refreshList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (Config.attente && Config.btn != null) {
                int index = int.Parse(Config.btn.Name.Replace("btnfen", "")) - 1;
                Config.raccourcis[index] = keyData;
                Config.btn.Text = keyData.ToString();
                Config.btn = null;
                Config.attente = false;
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
    }
}
