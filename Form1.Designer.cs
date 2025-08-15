namespace Organizer {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnfen18 = new System.Windows.Forms.Button();
            this.btnfen17 = new System.Windows.Forms.Button();
            this.btnfen16 = new System.Windows.Forms.Button();
            this.btnfen15 = new System.Windows.Forms.Button();
            this.btnfen14 = new System.Windows.Forms.Button();
            this.btnfen13 = new System.Windows.Forms.Button();
            this.btnfen12 = new System.Windows.Forms.Button();
            this.btnfen11 = new System.Windows.Forms.Button();
            this.btnfen10 = new System.Windows.Forms.Button();
            this.btnfen9 = new System.Windows.Forms.Button();
            this.btnfen8 = new System.Windows.Forms.Button();
            this.btnfen7 = new System.Windows.Forms.Button();
            this.btnfen6 = new System.Windows.Forms.Button();
            this.btnfen5 = new System.Windows.Forms.Button();
            this.btnfen4 = new System.Windows.Forms.Button();
            this.btnfen3 = new System.Windows.Forms.Button();
            this.btnfen2 = new System.Windows.Forms.Button();
            this.btnfen1 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Organizer - En cours d\'excution";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseToolStripMenuItem.Image")));
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(380, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fenêtres";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(24, 394);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Organizer.Properties.Resources.bouton_actualiser;
            this.pictureBox1.Location = new System.Drawing.Point(338, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "dofus.exe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filtrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(38, 36);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(328, 394);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnfen18);
            this.tabPage2.Controls.Add(this.btnfen17);
            this.tabPage2.Controls.Add(this.btnfen16);
            this.tabPage2.Controls.Add(this.btnfen15);
            this.tabPage2.Controls.Add(this.btnfen14);
            this.tabPage2.Controls.Add(this.btnfen13);
            this.tabPage2.Controls.Add(this.btnfen12);
            this.tabPage2.Controls.Add(this.btnfen11);
            this.tabPage2.Controls.Add(this.btnfen10);
            this.tabPage2.Controls.Add(this.btnfen9);
            this.tabPage2.Controls.Add(this.btnfen8);
            this.tabPage2.Controls.Add(this.btnfen7);
            this.tabPage2.Controls.Add(this.btnfen6);
            this.tabPage2.Controls.Add(this.btnfen5);
            this.tabPage2.Controls.Add(this.btnfen4);
            this.tabPage2.Controls.Add(this.btnfen3);
            this.tabPage2.Controls.Add(this.btnfen2);
            this.tabPage2.Controls.Add(this.btnfen1);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(372, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raccourcis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnfen18
            // 
            this.btnfen18.Location = new System.Drawing.Point(135, 412);
            this.btnfen18.Name = "btnfen18";
            this.btnfen18.Size = new System.Drawing.Size(188, 23);
            this.btnfen18.TabIndex = 51;
            this.btnfen18.Text = "Aucun raccourci";
            this.btnfen18.UseVisualStyleBackColor = true;
            this.btnfen18.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen18.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen17
            // 
            this.btnfen17.Location = new System.Drawing.Point(135, 390);
            this.btnfen17.Name = "btnfen17";
            this.btnfen17.Size = new System.Drawing.Size(188, 23);
            this.btnfen17.TabIndex = 50;
            this.btnfen17.Text = "Aucun raccourci";
            this.btnfen17.UseVisualStyleBackColor = true;
            this.btnfen17.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen17.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen16
            // 
            this.btnfen16.Location = new System.Drawing.Point(135, 348);
            this.btnfen16.Name = "btnfen16";
            this.btnfen16.Size = new System.Drawing.Size(188, 23);
            this.btnfen16.TabIndex = 49;
            this.btnfen16.Text = "Aucun raccourci";
            this.btnfen16.UseVisualStyleBackColor = true;
            this.btnfen16.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen16.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen15
            // 
            this.btnfen15.Location = new System.Drawing.Point(135, 326);
            this.btnfen15.Name = "btnfen15";
            this.btnfen15.Size = new System.Drawing.Size(188, 23);
            this.btnfen15.TabIndex = 48;
            this.btnfen15.Text = "Aucun raccourci";
            this.btnfen15.UseVisualStyleBackColor = true;
            this.btnfen15.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen15.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen14
            // 
            this.btnfen14.Location = new System.Drawing.Point(135, 302);
            this.btnfen14.Name = "btnfen14";
            this.btnfen14.Size = new System.Drawing.Size(188, 23);
            this.btnfen14.TabIndex = 47;
            this.btnfen14.Text = "Aucun raccourci";
            this.btnfen14.UseVisualStyleBackColor = true;
            this.btnfen14.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen14.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen13
            // 
            this.btnfen13.Location = new System.Drawing.Point(135, 280);
            this.btnfen13.Name = "btnfen13";
            this.btnfen13.Size = new System.Drawing.Size(188, 23);
            this.btnfen13.TabIndex = 46;
            this.btnfen13.Text = "Aucun raccourci";
            this.btnfen13.UseVisualStyleBackColor = true;
            this.btnfen13.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen13.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen12
            // 
            this.btnfen12.Location = new System.Drawing.Point(135, 256);
            this.btnfen12.Name = "btnfen12";
            this.btnfen12.Size = new System.Drawing.Size(188, 23);
            this.btnfen12.TabIndex = 45;
            this.btnfen12.Text = "Aucun raccourci";
            this.btnfen12.UseVisualStyleBackColor = true;
            this.btnfen12.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen12.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen11
            // 
            this.btnfen11.Location = new System.Drawing.Point(135, 234);
            this.btnfen11.Name = "btnfen11";
            this.btnfen11.Size = new System.Drawing.Size(188, 23);
            this.btnfen11.TabIndex = 44;
            this.btnfen11.Text = "Aucun raccourci";
            this.btnfen11.UseVisualStyleBackColor = true;
            this.btnfen11.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen11.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen10
            // 
            this.btnfen10.Location = new System.Drawing.Point(135, 210);
            this.btnfen10.Name = "btnfen10";
            this.btnfen10.Size = new System.Drawing.Size(188, 23);
            this.btnfen10.TabIndex = 43;
            this.btnfen10.Text = "Aucun raccourci";
            this.btnfen10.UseVisualStyleBackColor = true;
            this.btnfen10.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen10.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen9
            // 
            this.btnfen9.Location = new System.Drawing.Point(135, 188);
            this.btnfen9.Name = "btnfen9";
            this.btnfen9.Size = new System.Drawing.Size(188, 23);
            this.btnfen9.TabIndex = 42;
            this.btnfen9.Text = "Aucun raccourci";
            this.btnfen9.UseVisualStyleBackColor = true;
            this.btnfen9.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen9.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen8
            // 
            this.btnfen8.Location = new System.Drawing.Point(135, 164);
            this.btnfen8.Name = "btnfen8";
            this.btnfen8.Size = new System.Drawing.Size(188, 23);
            this.btnfen8.TabIndex = 41;
            this.btnfen8.Text = "Aucun raccourci";
            this.btnfen8.UseVisualStyleBackColor = true;
            this.btnfen8.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen8.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen7
            // 
            this.btnfen7.Location = new System.Drawing.Point(135, 142);
            this.btnfen7.Name = "btnfen7";
            this.btnfen7.Size = new System.Drawing.Size(188, 23);
            this.btnfen7.TabIndex = 40;
            this.btnfen7.Text = "Aucun raccourci";
            this.btnfen7.UseVisualStyleBackColor = true;
            this.btnfen7.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen7.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen6
            // 
            this.btnfen6.Location = new System.Drawing.Point(135, 118);
            this.btnfen6.Name = "btnfen6";
            this.btnfen6.Size = new System.Drawing.Size(188, 23);
            this.btnfen6.TabIndex = 39;
            this.btnfen6.Text = "Aucun raccourci";
            this.btnfen6.UseVisualStyleBackColor = true;
            this.btnfen6.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen6.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen5
            // 
            this.btnfen5.Location = new System.Drawing.Point(135, 96);
            this.btnfen5.Name = "btnfen5";
            this.btnfen5.Size = new System.Drawing.Size(188, 23);
            this.btnfen5.TabIndex = 38;
            this.btnfen5.Text = "Aucun raccourci";
            this.btnfen5.UseVisualStyleBackColor = true;
            this.btnfen5.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen5.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen4
            // 
            this.btnfen4.Location = new System.Drawing.Point(135, 72);
            this.btnfen4.Name = "btnfen4";
            this.btnfen4.Size = new System.Drawing.Size(188, 23);
            this.btnfen4.TabIndex = 37;
            this.btnfen4.Text = "Aucun raccourci";
            this.btnfen4.UseVisualStyleBackColor = true;
            this.btnfen4.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen4.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen3
            // 
            this.btnfen3.Location = new System.Drawing.Point(135, 50);
            this.btnfen3.Name = "btnfen3";
            this.btnfen3.Size = new System.Drawing.Size(188, 23);
            this.btnfen3.TabIndex = 36;
            this.btnfen3.Text = "Aucun raccourci";
            this.btnfen3.UseVisualStyleBackColor = true;
            this.btnfen3.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen3.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen2
            // 
            this.btnfen2.Location = new System.Drawing.Point(135, 26);
            this.btnfen2.Name = "btnfen2";
            this.btnfen2.Size = new System.Drawing.Size(188, 23);
            this.btnfen2.TabIndex = 35;
            this.btnfen2.Text = "Aucun raccourci";
            this.btnfen2.UseVisualStyleBackColor = true;
            this.btnfen2.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen2.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // btnfen1
            // 
            this.btnfen1.Location = new System.Drawing.Point(135, 4);
            this.btnfen1.Name = "btnfen1";
            this.btnfen1.Size = new System.Drawing.Size(188, 23);
            this.btnfen1.TabIndex = 34;
            this.btnfen1.Text = "Aucun raccourci";
            this.btnfen1.UseVisualStyleBackColor = true;
            this.btnfen1.Click += new System.EventHandler(this.btnfen_Click);
            this.btnfen1.Leave += new System.EventHandler(this.btnLostFocus);
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(59, 417);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 13);
            this.label35.TabIndex = 33;
            this.label35.Text = "Précédente";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(63, 395);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 13);
            this.label36.TabIndex = 32;
            this.label36.Text = "Suivante";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Fenêtre 16";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Fenêtre 15";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Fenêtre 14";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Fenêtre 13";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fenêtre 12";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fenêtre 11";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fenêtre 10";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fenêtre 9";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Fenêtre 8";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Fenêtre 7";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fenêtre 6";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fenêtre 5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fenêtre 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fenêtre 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fenêtre 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fenêtre 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseHover += new System.EventHandler(this.fenhov);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 467);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Organizer";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnfen4;
        private System.Windows.Forms.Button btnfen3;
        private System.Windows.Forms.Button btnfen2;
        private System.Windows.Forms.Button btnfen1;
        private System.Windows.Forms.Button btnfen16;
        private System.Windows.Forms.Button btnfen15;
        private System.Windows.Forms.Button btnfen14;
        private System.Windows.Forms.Button btnfen13;
        private System.Windows.Forms.Button btnfen12;
        private System.Windows.Forms.Button btnfen11;
        private System.Windows.Forms.Button btnfen10;
        private System.Windows.Forms.Button btnfen9;
        private System.Windows.Forms.Button btnfen8;
        private System.Windows.Forms.Button btnfen7;
        private System.Windows.Forms.Button btnfen6;
        private System.Windows.Forms.Button btnfen5;
        private System.Windows.Forms.Button btnfen18;
        private System.Windows.Forms.Button btnfen17;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

