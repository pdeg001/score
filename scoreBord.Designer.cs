﻿namespace peter
{
    partial class scorebord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scorebord));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_p1_name = new System.Windows.Forms.Label();
            this.lbl_p2_name = new System.Windows.Forms.Label();
            this.lbl_p1_car_1 = new System.Windows.Forms.Label();
            this.lbl_p1_car_10 = new System.Windows.Forms.Label();
            this.lbl_p1_car_100 = new System.Windows.Forms.Label();
            this.lbl_p2_car_100 = new System.Windows.Forms.Label();
            this.lbl_p2_car_10 = new System.Windows.Forms.Label();
            this.lbl_p2_car_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1_make_100 = new System.Windows.Forms.Label();
            this.p1_make_10 = new System.Windows.Forms.Label();
            this.p1_make_1 = new System.Windows.Forms.Label();
            this.p2_make_100 = new System.Windows.Forms.Label();
            this.p2_make_10 = new System.Windows.Forms.Label();
            this.p2_make_1 = new System.Windows.Forms.Label();
            this.lbl_bg = new System.Windows.Forms.Label();
            this.lbl_innings = new System.Windows.Forms.Label();
            this.btn_nieuwe_partij = new System.Windows.Forms.Button();
            this.lbl_beurten = new System.Windows.Forms.Label();
            this.p1_progress = new System.Windows.Forms.ProgressBar();
            this.p2_progress = new System.Windows.Forms.ProgressBar();
            this.lbl_p1_moyenne = new System.Windows.Forms.Label();
            this.lbl_p1_prec = new System.Windows.Forms.Label();
            this.lbl_p2_perc = new System.Windows.Forms.Label();
            this.lbl_p2_moyenne = new System.Windows.Forms.Label();
            this.lbl_p1_temaken = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_p2_temaken = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lbl_game_timer = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIpNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p1Ball = new System.Windows.Forms.PictureBox();
            this.p2Ball = new System.Windows.Forms.PictureBox();
            this.PnlTijd = new System.Windows.Forms.Panel();
            this.LblDag = new System.Windows.Forms.Label();
            this.LblTijd = new System.Windows.Forms.Label();
            this.TmrTijd = new System.Windows.Forms.Timer(this.components);
            this.TmrPromo = new System.Windows.Forms.Timer(this.components);
            this.TmrInactive = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.lbl_inning_1 = new System.Windows.Forms.Label();
            this.lbl_inning_10 = new System.Windows.Forms.Label();
            this.lbl_inning_100 = new System.Windows.Forms.Label();
            this.pnl_Inning = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball)).BeginInit();
            this.PnlTijd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.pnl_Inning.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(602, 839);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 95);
            this.label1.TabIndex = 5;
            this.label1.Text = "Percentage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_p1_name
            // 
            this.lbl_p1_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p1_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_p1_name.Font = new System.Drawing.Font("Arial", 40F);
            this.lbl_p1_name.ForeColor = System.Drawing.Color.White;
            this.lbl_p1_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_p1_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_p1_name.Name = "lbl_p1_name";
            this.lbl_p1_name.Size = new System.Drawing.Size(600, 124);
            this.lbl_p1_name.TabIndex = 6;
            this.lbl_p1_name.Text = "Speler 1";
            this.lbl_p1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p1_name.Click += new System.EventHandler(this.lbl_p1_name_Click);
            this.lbl_p1_name.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_name_Paint);
            this.lbl_p1_name.MouseEnter += new System.EventHandler(this.Lbl_pName_MouseEnter);
            this.lbl_p1_name.MouseLeave += new System.EventHandler(this.Lbl_pName_MouseLeave);
            // 
            // lbl_p2_name
            // 
            this.lbl_p2_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p2_name.Font = new System.Drawing.Font("Arial", 40F);
            this.lbl_p2_name.ForeColor = System.Drawing.Color.White;
            this.lbl_p2_name.Location = new System.Drawing.Point(1319, 1);
            this.lbl_p2_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_p2_name.Name = "lbl_p2_name";
            this.lbl_p2_name.Size = new System.Drawing.Size(600, 124);
            this.lbl_p2_name.TabIndex = 6;
            this.lbl_p2_name.Text = "Speler 2";
            this.lbl_p2_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2_name.UseMnemonic = false;
            this.lbl_p2_name.Click += new System.EventHandler(this.lbl_p2_name_Click);
            this.lbl_p2_name.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_name_Paint);
            this.lbl_p2_name.MouseEnter += new System.EventHandler(this.Lbl_pName_MouseEnter);
            this.lbl_p2_name.MouseLeave += new System.EventHandler(this.Lbl_pName_MouseLeave);
            // 
            // lbl_p1_car_1
            // 
            this.lbl_p1_car_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p1_car_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_p1_car_1.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_p1_car_1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p1_car_1.Location = new System.Drawing.Point(378, 327);
            this.lbl_p1_car_1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 20);
            this.lbl_p1_car_1.Name = "lbl_p1_car_1";
            this.lbl_p1_car_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p1_car_1.Size = new System.Drawing.Size(180, 240);
            this.lbl_p1_car_1.TabIndex = 8;
            this.lbl_p1_car_1.Tag = "1";
            this.lbl_p1_car_1.Text = "0";
            this.lbl_p1_car_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p1_car_1.UseMnemonic = false;
            this.lbl_p1_car_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Caram);
            // 
            // lbl_p1_car_10
            // 
            this.lbl_p1_car_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p1_car_10.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_p1_car_10.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p1_car_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p1_car_10.Location = new System.Drawing.Point(200, 327);
            this.lbl_p1_car_10.Name = "lbl_p1_car_10";
            this.lbl_p1_car_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p1_car_10.Size = new System.Drawing.Size(180, 240);
            this.lbl_p1_car_10.TabIndex = 9;
            this.lbl_p1_car_10.Tag = "10";
            this.lbl_p1_car_10.Text = "0";
            this.lbl_p1_car_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p1_car_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Caram);
            // 
            // lbl_p1_car_100
            // 
            this.lbl_p1_car_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p1_car_100.Font = new System.Drawing.Font("Arial", 160F);
            this.lbl_p1_car_100.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p1_car_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p1_car_100.Location = new System.Drawing.Point(15, 327);
            this.lbl_p1_car_100.Name = "lbl_p1_car_100";
            this.lbl_p1_car_100.Size = new System.Drawing.Size(180, 240);
            this.lbl_p1_car_100.TabIndex = 10;
            this.lbl_p1_car_100.Tag = "100";
            this.lbl_p1_car_100.Text = "0";
            this.lbl_p1_car_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p1_car_100.UseMnemonic = false;
            this.lbl_p1_car_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Caram);
            // 
            // lbl_p2_car_100
            // 
            this.lbl_p2_car_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p2_car_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_p2_car_100.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_p2_car_100.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p2_car_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p2_car_100.Location = new System.Drawing.Point(15, 332);
            this.lbl_p2_car_100.Name = "lbl_p2_car_100";
            this.lbl_p2_car_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p2_car_100.Size = new System.Drawing.Size(180, 221);
            this.lbl_p2_car_100.TabIndex = 13;
            this.lbl_p2_car_100.Tag = "100";
            this.lbl_p2_car_100.Text = "0";
            this.lbl_p2_car_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2_car_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Caram);
            // 
            // lbl_p2_car_10
            // 
            this.lbl_p2_car_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p2_car_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_p2_car_10.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_p2_car_10.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p2_car_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p2_car_10.Location = new System.Drawing.Point(200, 332);
            this.lbl_p2_car_10.Name = "lbl_p2_car_10";
            this.lbl_p2_car_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p2_car_10.Size = new System.Drawing.Size(180, 221);
            this.lbl_p2_car_10.TabIndex = 12;
            this.lbl_p2_car_10.Tag = "10";
            this.lbl_p2_car_10.Text = "0";
            this.lbl_p2_car_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2_car_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Caram);
            // 
            // lbl_p2_car_1
            // 
            this.lbl_p2_car_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p2_car_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_p2_car_1.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_p2_car_1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p2_car_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p2_car_1.Location = new System.Drawing.Point(384, 333);
            this.lbl_p2_car_1.Name = "lbl_p2_car_1";
            this.lbl_p2_car_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p2_car_1.Size = new System.Drawing.Size(180, 221);
            this.lbl_p2_car_1.TabIndex = 11;
            this.lbl_p2_car_1.Tag = "1";
            this.lbl_p2_car_1.Text = "0";
            this.lbl_p2_car_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2_car_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Caram);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(213)))));
            this.label3.Location = new System.Drawing.Point(602, 740);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(709, 95);
            this.label3.TabIndex = 14;
            this.label3.Text = "Moyenne";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // p1_make_100
            // 
            this.p1_make_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p1_make_100.Font = new System.Drawing.Font("Arial", 120F);
            this.p1_make_100.ForeColor = System.Drawing.Color.Yellow;
            this.p1_make_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1_make_100.Location = new System.Drawing.Point(20, 59);
            this.p1_make_100.Name = "p1_make_100";
            this.p1_make_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p1_make_100.Size = new System.Drawing.Size(170, 182);
            this.p1_make_100.TabIndex = 18;
            this.p1_make_100.Tag = "100";
            this.p1_make_100.Text = "0";
            this.p1_make_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1_make_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Make);
            // 
            // p1_make_10
            // 
            this.p1_make_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p1_make_10.Font = new System.Drawing.Font("Arial", 120F);
            this.p1_make_10.ForeColor = System.Drawing.Color.Yellow;
            this.p1_make_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1_make_10.Location = new System.Drawing.Point(205, 59);
            this.p1_make_10.Name = "p1_make_10";
            this.p1_make_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p1_make_10.Size = new System.Drawing.Size(170, 182);
            this.p1_make_10.TabIndex = 17;
            this.p1_make_10.Tag = "10";
            this.p1_make_10.Text = "0";
            this.p1_make_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1_make_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Make);
            // 
            // p1_make_1
            // 
            this.p1_make_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p1_make_1.Font = new System.Drawing.Font("Arial", 120F);
            this.p1_make_1.ForeColor = System.Drawing.Color.Yellow;
            this.p1_make_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1_make_1.Location = new System.Drawing.Point(383, 59);
            this.p1_make_1.Name = "p1_make_1";
            this.p1_make_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p1_make_1.Size = new System.Drawing.Size(170, 182);
            this.p1_make_1.TabIndex = 16;
            this.p1_make_1.Tag = "1";
            this.p1_make_1.Text = "0";
            this.p1_make_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1_make_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Make);
            // 
            // p2_make_100
            // 
            this.p2_make_100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p2_make_100.Font = new System.Drawing.Font("Arial", 120F);
            this.p2_make_100.ForeColor = System.Drawing.Color.Yellow;
            this.p2_make_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_100.Location = new System.Drawing.Point(20, 58);
            this.p2_make_100.Name = "p2_make_100";
            this.p2_make_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p2_make_100.Size = new System.Drawing.Size(170, 182);
            this.p2_make_100.TabIndex = 21;
            this.p2_make_100.Tag = "100";
            this.p2_make_100.Text = "0";
            this.p2_make_100.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_100.Paint += new System.Windows.Forms.PaintEventHandler(this.p2_make_100_Paint);
            this.p2_make_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Make);
            // 
            // p2_make_10
            // 
            this.p2_make_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p2_make_10.Font = new System.Drawing.Font("Arial", 120F);
            this.p2_make_10.ForeColor = System.Drawing.Color.Yellow;
            this.p2_make_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_10.Location = new System.Drawing.Point(205, 56);
            this.p2_make_10.Name = "p2_make_10";
            this.p2_make_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p2_make_10.Size = new System.Drawing.Size(170, 182);
            this.p2_make_10.TabIndex = 20;
            this.p2_make_10.Tag = "10";
            this.p2_make_10.Text = "0";
            this.p2_make_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2_make_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Make);
            // 
            // p2_make_1
            // 
            this.p2_make_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p2_make_1.Font = new System.Drawing.Font("Arial", 120F);
            this.p2_make_1.ForeColor = System.Drawing.Color.Yellow;
            this.p2_make_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_1.Location = new System.Drawing.Point(389, 56);
            this.p2_make_1.Name = "p2_make_1";
            this.p2_make_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p2_make_1.Size = new System.Drawing.Size(170, 182);
            this.p2_make_1.TabIndex = 19;
            this.p2_make_1.Tag = "1";
            this.p2_make_1.Text = "0";
            this.p2_make_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2_make_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Make);
            // 
            // lbl_bg
            // 
            this.lbl_bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_bg.Font = new System.Drawing.Font("Arial", 130F);
            this.lbl_bg.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_bg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_bg.Location = new System.Drawing.Point(3, 125);
            this.lbl_bg.Name = "lbl_bg";
            this.lbl_bg.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_bg.Size = new System.Drawing.Size(1919, 610);
            this.lbl_bg.TabIndex = 22;
            this.lbl_bg.Tag = "100";
            this.lbl_bg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_innings
            // 
            this.lbl_innings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_innings.Font = new System.Drawing.Font("Arial", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_innings.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_innings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_innings.Location = new System.Drawing.Point(733, 759);
            this.lbl_innings.Name = "lbl_innings";
            this.lbl_innings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_innings.Size = new System.Drawing.Size(450, 221);
            this.lbl_innings.TabIndex = 23;
            this.lbl_innings.Tag = "1";
            this.lbl_innings.Text = "001";
            this.lbl_innings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_innings.Visible = false;
            this.lbl_innings.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_innings.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_innings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetInning);
            // 
            // btn_nieuwe_partij
            // 
            this.btn_nieuwe_partij.BackColor = System.Drawing.Color.Green;
            this.btn_nieuwe_partij.FlatAppearance.BorderSize = 0;
            this.btn_nieuwe_partij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nieuwe_partij.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nieuwe_partij.ForeColor = System.Drawing.Color.White;
            this.btn_nieuwe_partij.Location = new System.Drawing.Point(1332, 942);
            this.btn_nieuwe_partij.Name = "btn_nieuwe_partij";
            this.btn_nieuwe_partij.Size = new System.Drawing.Size(580, 95);
            this.btn_nieuwe_partij.TabIndex = 26;
            this.btn_nieuwe_partij.Text = "Nieuwe Partij";
            this.btn_nieuwe_partij.UseVisualStyleBackColor = false;
            this.btn_nieuwe_partij.Click += new System.EventHandler(this.btn_nieuwe_partij_Click);
            this.btn_nieuwe_partij.MouseEnter += new System.EventHandler(this.btn_nieuwe_partij_MouseEnter);
            this.btn_nieuwe_partij.MouseLeave += new System.EventHandler(this.btn_nieuwe_partij_MouseLeave);
            // 
            // lbl_beurten
            // 
            this.lbl_beurten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_beurten.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_beurten.ForeColor = System.Drawing.Color.White;
            this.lbl_beurten.Location = new System.Drawing.Point(786, 362);
            this.lbl_beurten.Name = "lbl_beurten";
            this.lbl_beurten.Size = new System.Drawing.Size(346, 73);
            this.lbl_beurten.TabIndex = 27;
            this.lbl_beurten.Text = "Beurten";
            this.lbl_beurten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_progress
            // 
            this.p1_progress.BackColor = System.Drawing.Color.White;
            this.p1_progress.ForeColor = System.Drawing.Color.Lime;
            this.p1_progress.Location = new System.Drawing.Point(10, 574);
            this.p1_progress.MarqueeAnimationSpeed = 0;
            this.p1_progress.Name = "p1_progress";
            this.p1_progress.Size = new System.Drawing.Size(580, 36);
            this.p1_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.p1_progress.TabIndex = 32;
            // 
            // p2_progress
            // 
            this.p2_progress.BackColor = System.Drawing.Color.White;
            this.p2_progress.ForeColor = System.Drawing.Color.Lime;
            this.p2_progress.Location = new System.Drawing.Point(10, 571);
            this.p2_progress.Name = "p2_progress";
            this.p2_progress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.p2_progress.Size = new System.Drawing.Size(580, 36);
            this.p2_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.p2_progress.TabIndex = 33;
            // 
            // lbl_p1_moyenne
            // 
            this.lbl_p1_moyenne.BackColor = System.Drawing.Color.White;
            this.lbl_p1_moyenne.Font = new System.Drawing.Font("Arial", 70F);
            this.lbl_p1_moyenne.ForeColor = System.Drawing.Color.Black;
            this.lbl_p1_moyenne.Location = new System.Drawing.Point(10, 740);
            this.lbl_p1_moyenne.Name = "lbl_p1_moyenne";
            this.lbl_p1_moyenne.Size = new System.Drawing.Size(580, 95);
            this.lbl_p1_moyenne.TabIndex = 34;
            this.lbl_p1_moyenne.Text = "0.000";
            this.lbl_p1_moyenne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1_prec
            // 
            this.lbl_p1_prec.BackColor = System.Drawing.Color.White;
            this.lbl_p1_prec.Font = new System.Drawing.Font("Arial", 70F);
            this.lbl_p1_prec.ForeColor = System.Drawing.Color.Black;
            this.lbl_p1_prec.Location = new System.Drawing.Point(10, 840);
            this.lbl_p1_prec.Name = "lbl_p1_prec";
            this.lbl_p1_prec.Size = new System.Drawing.Size(580, 95);
            this.lbl_p1_prec.TabIndex = 35;
            this.lbl_p1_prec.Text = "0.000";
            this.lbl_p1_prec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2_perc
            // 
            this.lbl_p2_perc.BackColor = System.Drawing.Color.White;
            this.lbl_p2_perc.Font = new System.Drawing.Font("Arial", 70F);
            this.lbl_p2_perc.ForeColor = System.Drawing.Color.Black;
            this.lbl_p2_perc.Location = new System.Drawing.Point(1332, 839);
            this.lbl_p2_perc.Name = "lbl_p2_perc";
            this.lbl_p2_perc.Size = new System.Drawing.Size(580, 95);
            this.lbl_p2_perc.TabIndex = 37;
            this.lbl_p2_perc.Text = "0.000";
            this.lbl_p2_perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2_moyenne
            // 
            this.lbl_p2_moyenne.BackColor = System.Drawing.Color.White;
            this.lbl_p2_moyenne.Font = new System.Drawing.Font("Arial", 70F);
            this.lbl_p2_moyenne.ForeColor = System.Drawing.Color.Black;
            this.lbl_p2_moyenne.Location = new System.Drawing.Point(1332, 740);
            this.lbl_p2_moyenne.Name = "lbl_p2_moyenne";
            this.lbl_p2_moyenne.Size = new System.Drawing.Size(580, 95);
            this.lbl_p2_moyenne.TabIndex = 36;
            this.lbl_p2_moyenne.Text = "0.000";
            this.lbl_p2_moyenne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1_temaken
            // 
            this.lbl_p1_temaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p1_temaken.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_temaken.ForeColor = System.Drawing.Color.White;
            this.lbl_p1_temaken.Location = new System.Drawing.Point(84, 0);
            this.lbl_p1_temaken.Name = "lbl_p1_temaken";
            this.lbl_p1_temaken.Size = new System.Drawing.Size(430, 53);
            this.lbl_p1_temaken.TabIndex = 38;
            this.lbl_p1_temaken.Text = "Te maken";
            this.lbl_p1_temaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.label5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(550, 73);
            this.label5.TabIndex = 39;
            this.label5.Text = "Caramboles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.label6.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(550, 73);
            this.label6.TabIndex = 40;
            this.label6.Text = "Caramboles";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2_temaken
            // 
            this.lbl_p2_temaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lbl_p2_temaken.Font = new System.Drawing.Font("Arial", 28F);
            this.lbl_p2_temaken.ForeColor = System.Drawing.Color.White;
            this.lbl_p2_temaken.Location = new System.Drawing.Point(83, 0);
            this.lbl_p2_temaken.Name = "lbl_p2_temaken";
            this.lbl_p2_temaken.Size = new System.Drawing.Size(430, 53);
            this.lbl_p2_temaken.TabIndex = 41;
            this.lbl_p2_temaken.Text = "Te maken";
            this.lbl_p2_temaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.White;
            this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLogo.Location = new System.Drawing.Point(602, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(717, 332);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 42;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // lbl_game_timer
            // 
            this.lbl_game_timer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_game_timer.Font = new System.Drawing.Font("Arial", 70F);
            this.lbl_game_timer.ForeColor = System.Drawing.Color.Silver;
            this.lbl_game_timer.Location = new System.Drawing.Point(671, 951);
            this.lbl_game_timer.Name = "lbl_game_timer";
            this.lbl_game_timer.Size = new System.Drawing.Size(571, 95);
            this.lbl_game_timer.TabIndex = 43;
            this.lbl_game_timer.Text = "00:00";
            this.lbl_game_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_game_timer.Click += new System.EventHandler(this.lbl_game_timer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mouse1.jpg");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.lbl_p2_temaken);
            this.panel1.Controls.Add(this.p2_make_1);
            this.panel1.Controls.Add(this.p2_make_10);
            this.panel1.Controls.Add(this.p2_make_100);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_p2_car_1);
            this.panel1.Controls.Add(this.lbl_p2_car_10);
            this.panel1.Controls.Add(this.lbl_p2_car_100);
            this.panel1.Controls.Add(this.p2_progress);
            this.panel1.Location = new System.Drawing.Point(1321, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 610);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.lbl_p1_temaken);
            this.panel2.Controls.Add(this.p1_make_100);
            this.panel2.Controls.Add(this.p1_make_1);
            this.panel2.Controls.Add(this.p1_make_10);
            this.panel2.Controls.Add(this.lbl_p1_car_100);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_p1_car_1);
            this.panel2.Controls.Add(this.lbl_p1_car_10);
            this.panel2.Controls.Add(this.p1_progress);
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 610);
            this.panel2.TabIndex = 46;
            // 
            // lblIpNumber
            // 
            this.lblIpNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpNumber.ForeColor = System.Drawing.Color.LightGray;
            this.lblIpNumber.Location = new System.Drawing.Point(1796, 1047);
            this.lblIpNumber.Name = "lblIpNumber";
            this.lblIpNumber.Size = new System.Drawing.Size(117, 24);
            this.lblIpNumber.TabIndex = 47;
            this.lblIpNumber.Text = "0.0.0.0";
            this.lblIpNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIpNumber.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(1330, 1047);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "V1.0.9";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p1Ball
            // 
            this.p1Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p1Ball.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball.Image")));
            this.p1Ball.Location = new System.Drawing.Point(602, 501);
            this.p1Ball.Name = "p1Ball";
            this.p1Ball.Size = new System.Drawing.Size(117, 119);
            this.p1Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball.TabIndex = 48;
            this.p1Ball.TabStop = false;
            this.p1Ball.Visible = false;
            // 
            // p2Ball
            // 
            this.p2Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.p2Ball.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball.Image")));
            this.p2Ball.Location = new System.Drawing.Point(1196, 501);
            this.p2Ball.Name = "p2Ball";
            this.p2Ball.Size = new System.Drawing.Size(117, 119);
            this.p2Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball.TabIndex = 49;
            this.p2Ball.TabStop = false;
            this.p2Ball.Visible = false;
            // 
            // PnlTijd
            // 
            this.PnlTijd.Controls.Add(this.LblDag);
            this.PnlTijd.Controls.Add(this.LblTijd);
            this.PnlTijd.Location = new System.Drawing.Point(10, 937);
            this.PnlTijd.Name = "PnlTijd";
            this.PnlTijd.Size = new System.Drawing.Size(580, 132);
            this.PnlTijd.TabIndex = 50;
            // 
            // LblDag
            // 
            this.LblDag.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDag.ForeColor = System.Drawing.Color.Silver;
            this.LblDag.Location = new System.Drawing.Point(8, 65);
            this.LblDag.Name = "LblDag";
            this.LblDag.Size = new System.Drawing.Size(540, 46);
            this.LblDag.TabIndex = 1;
            this.LblDag.Text = "label2";
            // 
            // LblTijd
            // 
            this.LblTijd.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.LblTijd.ForeColor = System.Drawing.Color.Silver;
            this.LblTijd.Location = new System.Drawing.Point(2, 4);
            this.LblTijd.Name = "LblTijd";
            this.LblTijd.Size = new System.Drawing.Size(214, 53);
            this.LblTijd.TabIndex = 0;
            this.LblTijd.Text = "label2";
            // 
            // TmrTijd
            // 
            this.TmrTijd.Enabled = true;
            this.TmrTijd.Interval = 10000;
            this.TmrTijd.Tick += new System.EventHandler(this.TmrTijd_Tick);
            // 
            // TmrPromo
            // 
            this.TmrPromo.Interval = 5000;
            this.TmrPromo.Tick += new System.EventHandler(this.TmrPromo_Tick);
            // 
            // TmrInactive
            // 
            this.TmrInactive.Enabled = true;
            this.TmrInactive.Interval = 300000;
            this.TmrInactive.Tick += new System.EventHandler(this.TmrInactive_Tick);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.Filter = "cnf.44";
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // lbl_inning_1
            // 
            this.lbl_inning_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inning_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_inning_1.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_inning_1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_inning_1.Location = new System.Drawing.Point(307, 3);
            this.lbl_inning_1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 20);
            this.lbl_inning_1.Name = "lbl_inning_1";
            this.lbl_inning_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_inning_1.Size = new System.Drawing.Size(145, 221);
            this.lbl_inning_1.TabIndex = 40;
            this.lbl_inning_1.Tag = "1";
            this.lbl_inning_1.Text = "0";
            this.lbl_inning_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_inning_1.UseMnemonic = false;
            this.lbl_inning_1.MouseEnter += new System.EventHandler(this.lbl_inning_100_MouseEnter);
            this.lbl_inning_1.MouseLeave += new System.EventHandler(this.lbl_inning_100_MouseLeave);
            this.lbl_inning_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetInning);
            // 
            // lbl_inning_10
            // 
            this.lbl_inning_10.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inning_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_inning_10.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_inning_10.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_inning_10.Location = new System.Drawing.Point(162, 3);
            this.lbl_inning_10.Margin = new System.Windows.Forms.Padding(3, 0, 0, 20);
            this.lbl_inning_10.Name = "lbl_inning_10";
            this.lbl_inning_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_inning_10.Size = new System.Drawing.Size(142, 221);
            this.lbl_inning_10.TabIndex = 51;
            this.lbl_inning_10.Tag = "1";
            this.lbl_inning_10.Text = "0";
            this.lbl_inning_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_inning_10.UseMnemonic = false;
            this.lbl_inning_10.MouseEnter += new System.EventHandler(this.lbl_inning_100_MouseEnter);
            this.lbl_inning_10.MouseLeave += new System.EventHandler(this.lbl_inning_100_MouseLeave);
            this.lbl_inning_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetInning);
            // 
            // lbl_inning_100
            // 
            this.lbl_inning_100.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inning_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_inning_100.Font = new System.Drawing.Font("Arial", 150F);
            this.lbl_inning_100.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_inning_100.Location = new System.Drawing.Point(14, 3);
            this.lbl_inning_100.Margin = new System.Windows.Forms.Padding(3, 0, 0, 20);
            this.lbl_inning_100.Name = "lbl_inning_100";
            this.lbl_inning_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_inning_100.Size = new System.Drawing.Size(145, 221);
            this.lbl_inning_100.TabIndex = 52;
            this.lbl_inning_100.Tag = "1";
            this.lbl_inning_100.Text = "0";
            this.lbl_inning_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_inning_100.UseMnemonic = false;
            this.lbl_inning_100.MouseEnter += new System.EventHandler(this.lbl_inning_100_MouseEnter);
            this.lbl_inning_100.MouseLeave += new System.EventHandler(this.lbl_inning_100_MouseLeave);
            this.lbl_inning_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetInning);
            // 
            // pnl_Inning
            // 
            this.pnl_Inning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.pnl_Inning.Controls.Add(this.lbl_inning_10);
            this.pnl_Inning.Controls.Add(this.lbl_inning_1);
            this.pnl_Inning.Controls.Add(this.lbl_inning_100);
            this.pnl_Inning.Location = new System.Drawing.Point(728, 458);
            this.pnl_Inning.Name = "pnl_Inning";
            this.pnl_Inning.Size = new System.Drawing.Size(462, 226);
            this.pnl_Inning.TabIndex = 53;
            // 
            // scorebord
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(1)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Inning);
            this.Controls.Add(this.p2Ball);
            this.Controls.Add(this.p1Ball);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIpNumber);
            this.Controls.Add(this.lbl_p1_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_game_timer);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lbl_p2_perc);
            this.Controls.Add(this.lbl_p2_moyenne);
            this.Controls.Add(this.lbl_p1_prec);
            this.Controls.Add(this.lbl_p1_moyenne);
            this.Controls.Add(this.lbl_beurten);
            this.Controls.Add(this.btn_nieuwe_partij);
            this.Controls.Add(this.lbl_innings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_p2_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_bg);
            this.Controls.Add(this.PnlTijd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "scorebord";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "bord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball)).EndInit();
            this.PnlTijd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.pnl_Inning.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_p1_name;
        private System.Windows.Forms.Label lbl_p2_name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_p1_car_1;
        public System.Windows.Forms.Label lbl_p1_car_10;
        public System.Windows.Forms.Label lbl_p1_car_100;
        public System.Windows.Forms.Label lbl_p2_car_100;
        public System.Windows.Forms.Label lbl_p2_car_10;
        public System.Windows.Forms.Label lbl_p2_car_1;
        public System.Windows.Forms.Label p1_make_100;
        public System.Windows.Forms.Label p1_make_10;
        public System.Windows.Forms.Label p1_make_1;
        public System.Windows.Forms.Label p2_make_100;
        public System.Windows.Forms.Label p2_make_10;
        public System.Windows.Forms.Label p2_make_1;
        public System.Windows.Forms.Label lbl_bg;
        public System.Windows.Forms.Label lbl_innings;
        private System.Windows.Forms.Button btn_nieuwe_partij;
        private System.Windows.Forms.Label lbl_beurten;
        private System.Windows.Forms.ProgressBar p1_progress;
        private System.Windows.Forms.ProgressBar p2_progress;
        private System.Windows.Forms.Label lbl_p1_moyenne;
        private System.Windows.Forms.Label lbl_p1_prec;
        private System.Windows.Forms.Label lbl_p2_perc;
        private System.Windows.Forms.Label lbl_p2_moyenne;
        private System.Windows.Forms.Label lbl_p1_temaken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_p2_temaken;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lbl_game_timer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIpNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox p1Ball;
        private System.Windows.Forms.PictureBox p2Ball;
        private System.Windows.Forms.Panel PnlTijd;
        private System.Windows.Forms.Label LblTijd;
        private System.Windows.Forms.Label LblDag;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        public System.Windows.Forms.Timer TmrTijd;
        public System.Windows.Forms.Timer TmrPromo;
        public System.Windows.Forms.Timer TmrInactive;
        public System.Windows.Forms.Label lbl_inning_100;
        public System.Windows.Forms.Label lbl_inning_10;
        public System.Windows.Forms.Label lbl_inning_1;
        private System.Windows.Forms.Panel pnl_Inning;
    }

    

}

