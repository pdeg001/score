namespace peter
{
    partial class TeamenSelectie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamenSelectie));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.P1NameHome = new System.Windows.Forms.Label();
            this.P2NameHome = new System.Windows.Forms.Label();
            this.P3NameHome = new System.Windows.Forms.Label();
            this.P4NameHome = new System.Windows.Forms.Label();
            this.P1NameVisit = new System.Windows.Forms.Label();
            this.P2NameVisit = new System.Windows.Forms.Label();
            this.P3NameVisit = new System.Windows.Forms.Label();
            this.P4NameVisit = new System.Windows.Forms.Label();
            this.lblClub1Name = new System.Windows.Forms.Label();
            this.lblClub2Name = new System.Windows.Forms.Label();
            this.P1MakeHome = new System.Windows.Forms.Label();
            this.P2MakeHome = new System.Windows.Forms.Label();
            this.P3MakeHome = new System.Windows.Forms.Label();
            this.P4MakeHome = new System.Windows.Forms.Label();
            this.P1MakeVisit = new System.Windows.Forms.Label();
            this.P2MakeVisit = new System.Windows.Forms.Label();
            this.P3MakeVisit = new System.Windows.Forms.Label();
            this.P4MakeVisit = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ImgPlayerStarts = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPlayerStarts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 48F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1920, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer spelers voor de komende partij";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.White;
            this.btn_continue.FlatAppearance.BorderSize = 0;
            this.btn_continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.Color.Black;
            this.btn_continue.Location = new System.Drawing.Point(1471, 938);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(448, 140);
            this.btn_continue.TabIndex = 3;
            this.btn_continue.Text = "Verder";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // P1NameHome
            // 
            this.P1NameHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P1NameHome.Font = new System.Drawing.Font("Arial", 52F);
            this.P1NameHome.ForeColor = System.Drawing.Color.Yellow;
            this.P1NameHome.Location = new System.Drawing.Point(0, 263);
            this.P1NameHome.Name = "P1NameHome";
            this.P1NameHome.Size = new System.Drawing.Size(767, 110);
            this.P1NameHome.TabIndex = 4;
            this.P1NameHome.Tag = "P1MakeHome";
            this.P1NameHome.Text = "Peter de Groot";
            this.P1NameHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1NameHome.UseCompatibleTextRendering = true;
            this.P1NameHome.MouseEnter += new System.EventHandler(this.GenHover);
            this.P1NameHome.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P1NameHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // P2NameHome
            // 
            this.P2NameHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P2NameHome.Font = new System.Drawing.Font("Arial", 52F);
            this.P2NameHome.ForeColor = System.Drawing.Color.Yellow;
            this.P2NameHome.Location = new System.Drawing.Point(0, 380);
            this.P2NameHome.Name = "P2NameHome";
            this.P2NameHome.Size = new System.Drawing.Size(767, 110);
            this.P2NameHome.TabIndex = 4;
            this.P2NameHome.Tag = "P2MakeHome";
            this.P2NameHome.Text = "Piet Oudeman";
            this.P2NameHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2NameHome.UseCompatibleTextRendering = true;
            this.P2NameHome.MouseEnter += new System.EventHandler(this.GenHover);
            this.P2NameHome.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P2NameHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // P3NameHome
            // 
            this.P3NameHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P3NameHome.Font = new System.Drawing.Font("Arial", 52F);
            this.P3NameHome.ForeColor = System.Drawing.Color.Yellow;
            this.P3NameHome.Location = new System.Drawing.Point(0, 497);
            this.P3NameHome.Name = "P3NameHome";
            this.P3NameHome.Size = new System.Drawing.Size(767, 110);
            this.P3NameHome.TabIndex = 4;
            this.P3NameHome.Tag = "P3MakeHome";
            this.P3NameHome.Text = "Speler 3";
            this.P3NameHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P3NameHome.UseCompatibleTextRendering = true;
            this.P3NameHome.MouseEnter += new System.EventHandler(this.GenHover);
            this.P3NameHome.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P3NameHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // P4NameHome
            // 
            this.P4NameHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P4NameHome.Font = new System.Drawing.Font("Arial", 52F);
            this.P4NameHome.ForeColor = System.Drawing.Color.Yellow;
            this.P4NameHome.Location = new System.Drawing.Point(0, 614);
            this.P4NameHome.Name = "P4NameHome";
            this.P4NameHome.Size = new System.Drawing.Size(767, 110);
            this.P4NameHome.TabIndex = 4;
            this.P4NameHome.Tag = "P4MakeHome";
            this.P4NameHome.Text = "Speler 4";
            this.P4NameHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P4NameHome.UseCompatibleTextRendering = true;
            this.P4NameHome.MouseEnter += new System.EventHandler(this.GenHover);
            this.P4NameHome.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P4NameHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // P1NameVisit
            // 
            this.P1NameVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P1NameVisit.Font = new System.Drawing.Font("Arial", 52F);
            this.P1NameVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P1NameVisit.Location = new System.Drawing.Point(1160, 263);
            this.P1NameVisit.Name = "P1NameVisit";
            this.P1NameVisit.Size = new System.Drawing.Size(759, 110);
            this.P1NameVisit.TabIndex = 4;
            this.P1NameVisit.Tag = "P1MakeVisit";
            this.P1NameVisit.Text = "Speler 1";
            this.P1NameVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1NameVisit.UseCompatibleTextRendering = true;
            this.P1NameVisit.MouseEnter += new System.EventHandler(this.GenHover);
            this.P1NameVisit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P1NameVisit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // P2NameVisit
            // 
            this.P2NameVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P2NameVisit.Font = new System.Drawing.Font("Arial", 52F);
            this.P2NameVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P2NameVisit.Location = new System.Drawing.Point(1160, 380);
            this.P2NameVisit.Name = "P2NameVisit";
            this.P2NameVisit.Size = new System.Drawing.Size(759, 110);
            this.P2NameVisit.TabIndex = 4;
            this.P2NameVisit.Tag = "P2MakeVisit";
            this.P2NameVisit.Text = "Speler 2";
            this.P2NameVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2NameVisit.UseCompatibleTextRendering = true;
            this.P2NameVisit.MouseEnter += new System.EventHandler(this.GenHover);
            this.P2NameVisit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P2NameVisit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // P3NameVisit
            // 
            this.P3NameVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P3NameVisit.Font = new System.Drawing.Font("Arial", 52F);
            this.P3NameVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P3NameVisit.Location = new System.Drawing.Point(1160, 497);
            this.P3NameVisit.Name = "P3NameVisit";
            this.P3NameVisit.Size = new System.Drawing.Size(759, 110);
            this.P3NameVisit.TabIndex = 4;
            this.P3NameVisit.Tag = "P3MakeVisit";
            this.P3NameVisit.Text = "Speler 3";
            this.P3NameVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P3NameVisit.UseCompatibleTextRendering = true;
            this.P3NameVisit.MouseEnter += new System.EventHandler(this.GenHover);
            this.P3NameVisit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P3NameVisit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // P4NameVisit
            // 
            this.P4NameVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.P4NameVisit.Font = new System.Drawing.Font("Arial", 52F);
            this.P4NameVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P4NameVisit.Location = new System.Drawing.Point(1160, 614);
            this.P4NameVisit.Name = "P4NameVisit";
            this.P4NameVisit.Size = new System.Drawing.Size(759, 110);
            this.P4NameVisit.TabIndex = 4;
            this.P4NameVisit.Tag = "P4MakeVisit";
            this.P4NameVisit.Text = "S. v Duivenvoorde";
            this.P4NameVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P4NameVisit.UseCompatibleTextRendering = true;
            this.P4NameVisit.MouseEnter += new System.EventHandler(this.GenHover);
            this.P4NameVisit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.P4NameVisit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblClub1Name
            // 
            this.lblClub1Name.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblClub1Name.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub1Name.ForeColor = System.Drawing.Color.Yellow;
            this.lblClub1Name.Location = new System.Drawing.Point(0, 177);
            this.lblClub1Name.Name = "lblClub1Name";
            this.lblClub1Name.Size = new System.Drawing.Size(959, 81);
            this.lblClub1Name.TabIndex = 4;
            this.lblClub1Name.Text = "3BV de Parelhof";
            this.lblClub1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClub2Name
            // 
            this.lblClub2Name.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblClub2Name.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub2Name.ForeColor = System.Drawing.Color.Yellow;
            this.lblClub2Name.Location = new System.Drawing.Point(970, 177);
            this.lblClub2Name.Name = "lblClub2Name";
            this.lblClub2Name.Size = new System.Drawing.Size(950, 81);
            this.lblClub2Name.TabIndex = 4;
            this.lblClub2Name.Text = "3BV de Parelhof";
            this.lblClub2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P1MakeHome
            // 
            this.P1MakeHome.BackColor = System.Drawing.Color.Blue;
            this.P1MakeHome.Font = new System.Drawing.Font("Arial", 64F);
            this.P1MakeHome.ForeColor = System.Drawing.Color.Yellow;
            this.P1MakeHome.Location = new System.Drawing.Point(773, 263);
            this.P1MakeHome.Name = "P1MakeHome";
            this.P1MakeHome.Size = new System.Drawing.Size(186, 110);
            this.P1MakeHome.TabIndex = 4;
            this.P1MakeHome.Text = "39";
            this.P1MakeHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1MakeHome.UseCompatibleTextRendering = true;
            this.P1MakeHome.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P1MakeHome.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // P2MakeHome
            // 
            this.P2MakeHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.P2MakeHome.Font = new System.Drawing.Font("Arial", 64F);
            this.P2MakeHome.ForeColor = System.Drawing.Color.Yellow;
            this.P2MakeHome.Location = new System.Drawing.Point(773, 380);
            this.P2MakeHome.Name = "P2MakeHome";
            this.P2MakeHome.Size = new System.Drawing.Size(186, 110);
            this.P2MakeHome.TabIndex = 4;
            this.P2MakeHome.Text = "26";
            this.P2MakeHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2MakeHome.UseCompatibleTextRendering = true;
            this.P2MakeHome.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P2MakeHome.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // P3MakeHome
            // 
            this.P3MakeHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.P3MakeHome.Font = new System.Drawing.Font("Arial", 64F);
            this.P3MakeHome.ForeColor = System.Drawing.Color.Yellow;
            this.P3MakeHome.Location = new System.Drawing.Point(773, 497);
            this.P3MakeHome.Name = "P3MakeHome";
            this.P3MakeHome.Size = new System.Drawing.Size(186, 110);
            this.P3MakeHome.TabIndex = 4;
            this.P3MakeHome.Text = "44";
            this.P3MakeHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P3MakeHome.UseCompatibleTextRendering = true;
            this.P3MakeHome.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P3MakeHome.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // P4MakeHome
            // 
            this.P4MakeHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.P4MakeHome.Font = new System.Drawing.Font("Arial", 64F);
            this.P4MakeHome.ForeColor = System.Drawing.Color.Yellow;
            this.P4MakeHome.Location = new System.Drawing.Point(775, 614);
            this.P4MakeHome.Name = "P4MakeHome";
            this.P4MakeHome.Size = new System.Drawing.Size(184, 110);
            this.P4MakeHome.TabIndex = 4;
            this.P4MakeHome.Text = "29";
            this.P4MakeHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P4MakeHome.UseCompatibleTextRendering = true;
            this.P4MakeHome.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P4MakeHome.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // P1MakeVisit
            // 
            this.P1MakeVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.P1MakeVisit.Font = new System.Drawing.Font("Arial", 64F);
            this.P1MakeVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P1MakeVisit.Location = new System.Drawing.Point(970, 263);
            this.P1MakeVisit.Name = "P1MakeVisit";
            this.P1MakeVisit.Size = new System.Drawing.Size(184, 110);
            this.P1MakeVisit.TabIndex = 4;
            this.P1MakeVisit.Text = "39";
            this.P1MakeVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1MakeVisit.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P1MakeVisit.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // P2MakeVisit
            // 
            this.P2MakeVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.P2MakeVisit.Font = new System.Drawing.Font("Arial", 64F);
            this.P2MakeVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P2MakeVisit.Location = new System.Drawing.Point(970, 380);
            this.P2MakeVisit.Name = "P2MakeVisit";
            this.P2MakeVisit.Size = new System.Drawing.Size(184, 110);
            this.P2MakeVisit.TabIndex = 4;
            this.P2MakeVisit.Text = "26";
            this.P2MakeVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2MakeVisit.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P2MakeVisit.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // P3MakeVisit
            // 
            this.P3MakeVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.P3MakeVisit.Font = new System.Drawing.Font("Arial", 64F);
            this.P3MakeVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P3MakeVisit.Location = new System.Drawing.Point(970, 497);
            this.P3MakeVisit.Name = "P3MakeVisit";
            this.P3MakeVisit.Size = new System.Drawing.Size(184, 110);
            this.P3MakeVisit.TabIndex = 4;
            this.P3MakeVisit.Text = "44";
            this.P3MakeVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P3MakeVisit.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P3MakeVisit.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // P4MakeVisit
            // 
            this.P4MakeVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.P4MakeVisit.Font = new System.Drawing.Font("Arial", 64F);
            this.P4MakeVisit.ForeColor = System.Drawing.Color.Yellow;
            this.P4MakeVisit.Location = new System.Drawing.Point(970, 614);
            this.P4MakeVisit.Name = "P4MakeVisit";
            this.P4MakeVisit.Size = new System.Drawing.Size(184, 110);
            this.P4MakeVisit.TabIndex = 4;
            this.P4MakeVisit.Tag = "";
            this.P4MakeVisit.Text = "291";
            this.P4MakeVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P4MakeVisit.UseCompatibleTextRendering = true;
            this.P4MakeVisit.MouseEnter += new System.EventHandler(this.GenHoverPlayerMake);
            this.P4MakeVisit.MouseLeave += new System.EventHandler(this.RestoreHoverPlayerMake);
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDiscipline.Font = new System.Drawing.Font("Arial", 48F);
            this.lblDiscipline.ForeColor = System.Drawing.Color.Yellow;
            this.lblDiscipline.Location = new System.Drawing.Point(0, 88);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(1920, 86);
            this.lblDiscipline.TabIndex = 1;
            this.lblDiscipline.Text = "3banden klein";
            this.lblDiscipline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(0, 938);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(448, 140);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Annuleer";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(720, 938);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 140);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sluit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImgPlayerStarts
            // 
            this.ImgPlayerStarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.ImgPlayerStarts.Image = global::peter.Properties.Resources.mouse;
            this.ImgPlayerStarts.InitialImage = global::peter.Properties.Resources.mouse;
            this.ImgPlayerStarts.Location = new System.Drawing.Point(1160, 614);
            this.ImgPlayerStarts.Name = "ImgPlayerStarts";
            this.ImgPlayerStarts.Size = new System.Drawing.Size(84, 110);
            this.ImgPlayerStarts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPlayerStarts.TabIndex = 5;
            this.ImgPlayerStarts.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // TeamenSelectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.ImgPlayerStarts);
            this.Controls.Add(this.P4NameVisit);
            this.Controls.Add(this.P4NameHome);
            this.Controls.Add(this.P3NameVisit);
            this.Controls.Add(this.P3NameHome);
            this.Controls.Add(this.P2NameVisit);
            this.Controls.Add(this.P2NameHome);
            this.Controls.Add(this.P1NameVisit);
            this.Controls.Add(this.lblClub2Name);
            this.Controls.Add(this.lblClub1Name);
            this.Controls.Add(this.P4MakeVisit);
            this.Controls.Add(this.P4MakeHome);
            this.Controls.Add(this.P3MakeVisit);
            this.Controls.Add(this.P3MakeHome);
            this.Controls.Add(this.P2MakeVisit);
            this.Controls.Add(this.P1MakeVisit);
            this.Controls.Add(this.P2MakeHome);
            this.Controls.Add(this.P1MakeHome);
            this.Controls.Add(this.P1NameHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeamenSelectie";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeamenSelectie";
            this.Load += new System.EventHandler(this.TeamenSelectie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPlayerStarts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label P1NameHome;
        private System.Windows.Forms.Label P2NameHome;
        private System.Windows.Forms.Label P3NameHome;
        private System.Windows.Forms.Label P4NameHome;
        private System.Windows.Forms.Label P1NameVisit;
        private System.Windows.Forms.Label P2NameVisit;
        private System.Windows.Forms.Label P3NameVisit;
        private System.Windows.Forms.Label P4NameVisit;
        private System.Windows.Forms.Label lblClub1Name;
        private System.Windows.Forms.Label lblClub2Name;
        private System.Windows.Forms.Label P1MakeHome;
        private System.Windows.Forms.Label P2MakeHome;
        private System.Windows.Forms.Label P3MakeHome;
        private System.Windows.Forms.Label P4MakeHome;
        private System.Windows.Forms.Label P1MakeVisit;
        private System.Windows.Forms.Label P2MakeVisit;
        private System.Windows.Forms.Label P3MakeVisit;
        private System.Windows.Forms.Label P4MakeVisit;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ImgPlayerStarts;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}