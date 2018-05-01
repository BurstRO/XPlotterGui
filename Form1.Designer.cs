﻿namespace XplotterGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grp_xPlotter = new System.Windows.Forms.GroupBox();
            this.lbl_CPURAM = new System.Windows.Forms.Label();
            this.lbl_RAM2 = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.NumericUpDown();
            this.lbl_RAM = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.NumericUpDown();
            this.lbl_CPU = new System.Windows.Forms.Label();
            this.btn_xPlotter = new System.Windows.Forms.Button();
            this.numericID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_xPlotter = new System.Windows.Forms.Label();
            this.xPlotter = new System.Windows.Forms.TextBox();
            this.grp_SSD = new System.Windows.Forms.GroupBox();
            this.btn_SSD = new System.Windows.Forms.Button();
            this.lbl_SSD2 = new System.Windows.Forms.Label();
            this.space = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.lbl_SSD3 = new System.Windows.Forms.Label();
            this.cachepct = new System.Windows.Forms.NumericUpDown();
            this.ssdCache = new System.Windows.Forms.TextBox();
            this.lbl_SSD1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.files = new System.Windows.Forms.Label();
            this.plotsize = new System.Windows.Forms.Label();
            this.snonce = new System.Windows.Forms.NumericUpDown();
            this.offset = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.npf = new System.Windows.Forms.NumericUpDown();
            this.moreFiles = new System.Windows.Forms.RadioButton();
            this.oneFile = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ntpValue = new System.Windows.Forms.RadioButton();
            this.ntpmax = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manualsn = new System.Windows.Forms.RadioButton();
            this.automaticsn = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Target = new System.Windows.Forms.Button();
            this.space2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ntp = new System.Windows.Forms.NumericUpDown();
            this.target = new System.Windows.Forms.TextBox();
            this.lbl_PFS1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.drive = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.shuffle = new System.Windows.Forms.CheckBox();
            this.grp_xPlotter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).BeginInit();
            this.grp_SSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cachepct)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snonce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npf)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drive)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plotter Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transfer Task";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "X-Plotter Executable|XPlotter_*.exe";
            // 
            // grp_xPlotter
            // 
            this.grp_xPlotter.Controls.Add(this.lbl_CPURAM);
            this.grp_xPlotter.Controls.Add(this.lbl_RAM2);
            this.grp_xPlotter.Controls.Add(this.ram);
            this.grp_xPlotter.Controls.Add(this.lbl_RAM);
            this.grp_xPlotter.Controls.Add(this.threads);
            this.grp_xPlotter.Controls.Add(this.lbl_CPU);
            this.grp_xPlotter.Controls.Add(this.btn_xPlotter);
            this.grp_xPlotter.Controls.Add(this.numericID);
            this.grp_xPlotter.Controls.Add(this.lbl_ID);
            this.grp_xPlotter.Controls.Add(this.lbl_xPlotter);
            this.grp_xPlotter.Controls.Add(this.xPlotter);
            this.grp_xPlotter.Location = new System.Drawing.Point(12, 12);
            this.grp_xPlotter.Name = "grp_xPlotter";
            this.grp_xPlotter.Size = new System.Drawing.Size(597, 105);
            this.grp_xPlotter.TabIndex = 0;
            this.grp_xPlotter.TabStop = false;
            this.grp_xPlotter.Text = "Xplotter Settings";
            // 
            // lbl_CPURAM
            // 
            this.lbl_CPURAM.AutoSize = true;
            this.lbl_CPURAM.Location = new System.Drawing.Point(9, 77);
            this.lbl_CPURAM.Name = "lbl_CPURAM";
            this.lbl_CPURAM.Size = new System.Drawing.Size(58, 13);
            this.lbl_CPURAM.TabIndex = 5;
            this.lbl_CPURAM.Text = "CPU/RAM";
            // 
            // lbl_RAM2
            // 
            this.lbl_RAM2.AutoSize = true;
            this.lbl_RAM2.Location = new System.Drawing.Point(378, 77);
            this.lbl_RAM2.Name = "lbl_RAM2";
            this.lbl_RAM2.Size = new System.Drawing.Size(22, 13);
            this.lbl_RAM2.TabIndex = 10;
            this.lbl_RAM2.Text = "GB";
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(308, 75);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(64, 20);
            this.ram.TabIndex = 9;
            this.ram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ram.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ram.ValueChanged += new System.EventHandler(this.ram_ValueChanged);
            // 
            // lbl_RAM
            // 
            this.lbl_RAM.AutoSize = true;
            this.lbl_RAM.Location = new System.Drawing.Point(258, 77);
            this.lbl_RAM.Name = "lbl_RAM";
            this.lbl_RAM.Size = new System.Drawing.Size(44, 13);
            this.lbl_RAM.TabIndex = 8;
            this.lbl_RAM.Text = "Memory";
            // 
            // threads
            // 
            this.threads.Location = new System.Drawing.Point(165, 75);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(64, 20);
            this.threads.TabIndex = 7;
            this.threads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.threads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.threads.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // lbl_CPU
            // 
            this.lbl_CPU.AutoSize = true;
            this.lbl_CPU.Location = new System.Drawing.Point(106, 77);
            this.lbl_CPU.Name = "lbl_CPU";
            this.lbl_CPU.Size = new System.Drawing.Size(53, 13);
            this.lbl_CPU.TabIndex = 6;
            this.lbl_CPU.Text = "#Threads";
            // 
            // btn_xPlotter
            // 
            this.btn_xPlotter.Location = new System.Drawing.Point(406, 21);
            this.btn_xPlotter.Name = "btn_xPlotter";
            this.btn_xPlotter.Size = new System.Drawing.Size(66, 20);
            this.btn_xPlotter.TabIndex = 2;
            this.btn_xPlotter.Text = "Browse";
            this.btn_xPlotter.UseVisualStyleBackColor = true;
            this.btn_xPlotter.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(105, 49);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(295, 20);
            this.numericID.TabIndex = 4;
            this.numericID.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(9, 52);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(60, 13);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Numeric ID";
            // 
            // lbl_xPlotter
            // 
            this.lbl_xPlotter.AutoSize = true;
            this.lbl_xPlotter.Location = new System.Drawing.Point(9, 24);
            this.lbl_xPlotter.Name = "lbl_xPlotter";
            this.lbl_xPlotter.Size = new System.Drawing.Size(87, 13);
            this.lbl_xPlotter.TabIndex = 0;
            this.lbl_xPlotter.Text = "Xplotter Location";
            // 
            // xPlotter
            // 
            this.xPlotter.Location = new System.Drawing.Point(105, 21);
            this.xPlotter.Name = "xPlotter";
            this.xPlotter.Size = new System.Drawing.Size(295, 20);
            this.xPlotter.TabIndex = 1;
            this.xPlotter.TextChanged += new System.EventHandler(this.xPlotter_TextChanged);
            // 
            // grp_SSD
            // 
            this.grp_SSD.Controls.Add(this.btn_SSD);
            this.grp_SSD.Controls.Add(this.lbl_SSD2);
            this.grp_SSD.Controls.Add(this.space);
            this.grp_SSD.Controls.Add(this.spaceLabel);
            this.grp_SSD.Controls.Add(this.lbl_SSD3);
            this.grp_SSD.Controls.Add(this.cachepct);
            this.grp_SSD.Controls.Add(this.ssdCache);
            this.grp_SSD.Controls.Add(this.lbl_SSD1);
            this.grp_SSD.Location = new System.Drawing.Point(13, 123);
            this.grp_SSD.Name = "grp_SSD";
            this.grp_SSD.Size = new System.Drawing.Size(596, 75);
            this.grp_SSD.TabIndex = 2;
            this.grp_SSD.TabStop = false;
            this.grp_SSD.Text = "SSD Cache Settings";
            // 
            // btn_SSD
            // 
            this.btn_SSD.Location = new System.Drawing.Point(216, 21);
            this.btn_SSD.Name = "btn_SSD";
            this.btn_SSD.Size = new System.Drawing.Size(66, 20);
            this.btn_SSD.TabIndex = 2;
            this.btn_SSD.Text = "Browse";
            this.btn_SSD.UseVisualStyleBackColor = true;
            this.btn_SSD.Click += new System.EventHandler(this.updateSSD_Click);
            // 
            // lbl_SSD2
            // 
            this.lbl_SSD2.AutoSize = true;
            this.lbl_SSD2.Location = new System.Drawing.Point(320, 25);
            this.lbl_SSD2.Name = "lbl_SSD2";
            this.lbl_SSD2.Size = new System.Drawing.Size(70, 13);
            this.lbl_SSD2.TabIndex = 3;
            this.lbl_SSD2.Text = "Space to use";
            // 
            // space
            // 
            this.space.AutoSize = true;
            this.space.Location = new System.Drawing.Point(101, 50);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(55, 13);
            this.space.TabIndex = 7;
            this.space.Text = "(available)";
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Location = new System.Drawing.Point(8, 50);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(38, 13);
            this.spaceLabel.TabIndex = 6;
            this.spaceLabel.Text = "Usage";
            // 
            // lbl_SSD3
            // 
            this.lbl_SSD3.AutoSize = true;
            this.lbl_SSD3.Location = new System.Drawing.Point(466, 25);
            this.lbl_SSD3.Name = "lbl_SSD3";
            this.lbl_SSD3.Size = new System.Drawing.Size(15, 13);
            this.lbl_SSD3.TabIndex = 5;
            this.lbl_SSD3.Text = "%";
            // 
            // cachepct
            // 
            this.cachepct.Location = new System.Drawing.Point(396, 23);
            this.cachepct.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.cachepct.Name = "cachepct";
            this.cachepct.Size = new System.Drawing.Size(64, 20);
            this.cachepct.TabIndex = 4;
            this.cachepct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cachepct.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.cachepct.ValueChanged += new System.EventHandler(this.cachepct_ValueChanged);
            // 
            // ssdCache
            // 
            this.ssdCache.Location = new System.Drawing.Point(104, 22);
            this.ssdCache.Name = "ssdCache";
            this.ssdCache.Size = new System.Drawing.Size(106, 20);
            this.ssdCache.TabIndex = 1;
            this.ssdCache.TextChanged += new System.EventHandler(this.ssdCache_TextChanged);
            // 
            // lbl_SSD1
            // 
            this.lbl_SSD1.AutoSize = true;
            this.lbl_SSD1.Location = new System.Drawing.Point(8, 25);
            this.lbl_SSD1.Name = "lbl_SSD1";
            this.lbl_SSD1.Size = new System.Drawing.Size(48, 13);
            this.lbl_SSD1.TabIndex = 0;
            this.lbl_SSD1.Text = "Location";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.files);
            this.groupBox3.Controls.Add(this.plotsize);
            this.groupBox3.Controls.Add(this.snonce);
            this.groupBox3.Controls.Add(this.offset);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btn_Target);
            this.groupBox3.Controls.Add(this.space2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ntp);
            this.groupBox3.Controls.Add(this.target);
            this.groupBox3.Controls.Add(this.lbl_PFS1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.drive);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 199);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plot File Settings";
            // 
            // files
            // 
            this.files.AutoSize = true;
            this.files.Location = new System.Drawing.Point(466, 168);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(55, 13);
            this.files.TabIndex = 19;
            this.files.Text = "(available)";
            // 
            // plotsize
            // 
            this.plotsize.AutoSize = true;
            this.plotsize.Location = new System.Drawing.Point(466, 145);
            this.plotsize.Name = "plotsize";
            this.plotsize.Size = new System.Drawing.Size(55, 13);
            this.plotsize.TabIndex = 18;
            this.plotsize.Text = "(available)";
            // 
            // snonce
            // 
            this.snonce.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.snonce.Location = new System.Drawing.Point(191, 109);
            this.snonce.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.snonce.Name = "snonce";
            this.snonce.Size = new System.Drawing.Size(138, 20);
            this.snonce.TabIndex = 17;
            this.snonce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.snonce.ThousandsSeparator = true;
            this.snonce.Enter += new System.EventHandler(this.snonce_Enter);
            // 
            // offset
            // 
            this.offset.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.offset.Location = new System.Drawing.Point(433, 82);
            this.offset.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(103, 20);
            this.offset.TabIndex = 10;
            this.offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.offset.ThousandsSeparator = true;
            this.offset.ValueChanged += new System.EventHandler(this.offset_ValueChanged);
            this.offset.Enter += new System.EventHandler(this.offset_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.npf);
            this.panel3.Controls.Add(this.moreFiles);
            this.panel3.Controls.Add(this.oneFile);
            this.panel3.Location = new System.Drawing.Point(99, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 27);
            this.panel3.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nonces";
            // 
            // npf
            // 
            this.npf.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.npf.Location = new System.Drawing.Point(198, 2);
            this.npf.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.npf.Name = "npf";
            this.npf.Size = new System.Drawing.Size(103, 20);
            this.npf.TabIndex = 2;
            this.npf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npf.ThousandsSeparator = true;
            this.npf.ValueChanged += new System.EventHandler(this.npf_ValueChanged);
            this.npf.Enter += new System.EventHandler(this.npf_Enter);
            // 
            // moreFiles
            // 
            this.moreFiles.AutoSize = true;
            this.moreFiles.Checked = true;
            this.moreFiles.Location = new System.Drawing.Point(97, 2);
            this.moreFiles.Name = "moreFiles";
            this.moreFiles.Size = new System.Drawing.Size(99, 17);
            this.moreFiles.TabIndex = 1;
            this.moreFiles.TabStop = true;
            this.moreFiles.Text = "Nonces per File";
            this.moreFiles.UseVisualStyleBackColor = true;
            // 
            // oneFile
            // 
            this.oneFile.AutoSize = true;
            this.oneFile.Location = new System.Drawing.Point(5, 2);
            this.oneFile.Name = "oneFile";
            this.oneFile.Size = new System.Drawing.Size(64, 17);
            this.oneFile.TabIndex = 0;
            this.oneFile.Text = "One File";
            this.oneFile.UseVisualStyleBackColor = true;
            this.oneFile.CheckedChanged += new System.EventHandler(this.oneFile_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ntpValue);
            this.panel2.Controls.Add(this.ntpmax);
            this.panel2.Location = new System.Drawing.Point(104, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 22);
            this.panel2.TabIndex = 12;
            // 
            // ntpValue
            // 
            this.ntpValue.AutoSize = true;
            this.ntpValue.Location = new System.Drawing.Point(92, 0);
            this.ntpValue.Name = "ntpValue";
            this.ntpValue.Size = new System.Drawing.Size(52, 17);
            this.ntpValue.TabIndex = 1;
            this.ntpValue.Text = "Value";
            this.ntpValue.UseVisualStyleBackColor = true;
            // 
            // ntpmax
            // 
            this.ntpmax.AutoSize = true;
            this.ntpmax.Checked = true;
            this.ntpmax.Location = new System.Drawing.Point(0, 0);
            this.ntpmax.Name = "ntpmax";
            this.ntpmax.Size = new System.Drawing.Size(69, 17);
            this.ntpmax.TabIndex = 0;
            this.ntpmax.TabStop = true;
            this.ntpmax.Text = "Maximum";
            this.ntpmax.UseVisualStyleBackColor = true;
            this.ntpmax.CheckedChanged += new System.EventHandler(this.ntpmax_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manualsn);
            this.panel1.Controls.Add(this.automaticsn);
            this.panel1.Location = new System.Drawing.Point(87, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 53);
            this.panel1.TabIndex = 6;
            // 
            // manualsn
            // 
            this.manualsn.AutoSize = true;
            this.manualsn.Location = new System.Drawing.Point(17, 35);
            this.manualsn.Name = "manualsn";
            this.manualsn.Size = new System.Drawing.Size(63, 17);
            this.manualsn.TabIndex = 1;
            this.manualsn.Text = "Manual ";
            this.manualsn.UseVisualStyleBackColor = true;
            // 
            // automaticsn
            // 
            this.automaticsn.AutoSize = true;
            this.automaticsn.Checked = true;
            this.automaticsn.Location = new System.Drawing.Point(17, 8);
            this.automaticsn.Name = "automaticsn";
            this.automaticsn.Size = new System.Drawing.Size(78, 17);
            this.automaticsn.TabIndex = 0;
            this.automaticsn.TabStop = true;
            this.automaticsn.Text = "Automatic: ";
            this.automaticsn.UseVisualStyleBackColor = true;
            this.automaticsn.CheckedChanged += new System.EventHandler(this.automaticsn_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nonces";
            // 
            // btn_Target
            // 
            this.btn_Target.Location = new System.Drawing.Point(405, 23);
            this.btn_Target.Name = "btn_Target";
            this.btn_Target.Size = new System.Drawing.Size(66, 20);
            this.btn_Target.TabIndex = 2;
            this.btn_Target.Text = "Browse";
            this.btn_Target.UseVisualStyleBackColor = true;
            this.btn_Target.Click += new System.EventHandler(this.button4_Click);
            // 
            // space2
            // 
            this.space2.AutoSize = true;
            this.space2.Location = new System.Drawing.Point(101, 55);
            this.space2.Name = "space2";
            this.space2.Size = new System.Drawing.Size(55, 13);
            this.space2.TabIndex = 4;
            this.space2.Text = "(available)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Available Space:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Files to Plot";
            // 
            // ntp
            // 
            this.ntp.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ntp.Location = new System.Drawing.Point(297, 143);
            this.ntp.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ntp.Name = "ntp";
            this.ntp.Size = new System.Drawing.Size(103, 20);
            this.ntp.TabIndex = 13;
            this.ntp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ntp.ThousandsSeparator = true;
            this.ntp.ValueChanged += new System.EventHandler(this.ntp_ValueChanged);
            this.ntp.Enter += new System.EventHandler(this.ntp_Enter);
            // 
            // target
            // 
            this.target.Location = new System.Drawing.Point(104, 23);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(295, 20);
            this.target.TabIndex = 1;
            this.target.TextChanged += new System.EventHandler(this.target_TextChanged);
            // 
            // lbl_PFS1
            // 
            this.lbl_PFS1.AutoSize = true;
            this.lbl_PFS1.Location = new System.Drawing.Point(8, 26);
            this.lbl_PFS1.Name = "lbl_PFS1";
            this.lbl_PFS1.Size = new System.Drawing.Size(70, 13);
            this.lbl_PFS1.TabIndex = 0;
            this.lbl_PFS1.Text = "Target Folder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nonces to plot";
            // 
            // drive
            // 
            this.drive.Location = new System.Drawing.Point(233, 82);
            this.drive.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.drive.Name = "drive";
            this.drive.Size = new System.Drawing.Size(64, 20);
            this.drive.TabIndex = 8;
            this.drive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.drive.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.drive.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.drive.Enter += new System.EventHandler(this.drive_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nonces offset per Drive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Drive#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Nonce";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 445);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(596, 232);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(304, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(286, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(304, 69);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(286, 152);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(285, 152);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Plotting!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 684);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.TabIndex = 60;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // shuffle
            // 
            this.shuffle.AutoSize = true;
            this.shuffle.Location = new System.Drawing.Point(24, 417);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(82, 17);
            this.shuffle.TabIndex = 61;
            this.shuffle.Text = "Poc1>Poc2";
            this.shuffle.UseVisualStyleBackColor = true;
            this.shuffle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 706);
            this.Controls.Add(this.shuffle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_SSD);
            this.Controls.Add(this.grp_xPlotter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Johnny\'s XPlotterGui+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_xPlotter.ResumeLayout(false);
            this.grp_xPlotter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).EndInit();
            this.grp_SSD.ResumeLayout(false);
            this.grp_SSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cachepct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snonce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npf)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drive)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox grp_xPlotter;
        private System.Windows.Forms.Label lbl_CPURAM;
        private System.Windows.Forms.Label lbl_RAM2;
        private System.Windows.Forms.NumericUpDown ram;
        private System.Windows.Forms.Label lbl_RAM;
        private System.Windows.Forms.NumericUpDown threads;
        private System.Windows.Forms.Label lbl_CPU;
        private System.Windows.Forms.Button btn_xPlotter;
        private System.Windows.Forms.TextBox numericID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_xPlotter;
        private System.Windows.Forms.TextBox xPlotter;
        private System.Windows.Forms.GroupBox grp_SSD;
        private System.Windows.Forms.Button btn_SSD;
        private System.Windows.Forms.Label lbl_SSD2;
        private System.Windows.Forms.Label space;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Label lbl_SSD3;
        private System.Windows.Forms.NumericUpDown cachepct;
        private System.Windows.Forms.TextBox ssdCache;
        private System.Windows.Forms.Label lbl_SSD1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Target;
        private System.Windows.Forms.Label space2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown npf;
        private System.Windows.Forms.RadioButton moreFiles;
        private System.Windows.Forms.RadioButton oneFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ntp;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label lbl_PFS1;
        private System.Windows.Forms.RadioButton ntpValue;
        private System.Windows.Forms.RadioButton ntpmax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton manualsn;
        private System.Windows.Forms.NumericUpDown drive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton automaticsn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown offset;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown snonce;
        private System.Windows.Forms.Label files;
        private System.Windows.Forms.Label plotsize;
        private System.Windows.Forms.CheckBox shuffle;
    }
}

