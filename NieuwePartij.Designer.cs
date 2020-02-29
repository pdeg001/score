namespace peter
{
    partial class NieuwePartij
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nee = new System.Windows.Forms.Button();
            this.btn_ja = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkSpelersInvoeren = new System.Windows.Forms.PictureBox();
            this.lbl_spelers_invoeren = new System.Windows.Forms.Label();
            this.lbl_buerten_automatisch = new System.Windows.Forms.Label();
            this.chk_auto_beurten = new System.Windows.Forms.PictureBox();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.txtP1Caroms = new System.Windows.Forms.TextBox();
            this.txtP2Caroms = new System.Windows.Forms.TextBox();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.btnP2Start = new System.Windows.Forms.Button();
            this.btnP1Start = new System.Windows.Forms.Button();
            this.lblExitApplication = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblNaam = new System.Windows.Forms.Label();
            this.LblMaken = new System.Windows.Forms.Label();
            this.LblBeginnen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chkSpelersInvoeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_auto_beurten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(292, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1221, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wilt u de partij beëindigen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_nee
            // 
            this.btn_nee.BackColor = System.Drawing.Color.White;
            this.btn_nee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nee.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nee.ForeColor = System.Drawing.Color.Black;
            this.btn_nee.Location = new System.Drawing.Point(295, 499);
            this.btn_nee.Name = "btn_nee";
            this.btn_nee.Size = new System.Drawing.Size(448, 164);
            this.btn_nee.TabIndex = 1;
            this.btn_nee.Text = "Nee";
            this.btn_nee.UseVisualStyleBackColor = false;
            this.btn_nee.Click += new System.EventHandler(this.btn_nee_Click);
            this.btn_nee.MouseEnter += new System.EventHandler(this.genHoverButton);
            this.btn_nee.MouseLeave += new System.EventHandler(this.restoreHoverButton);
            // 
            // btn_ja
            // 
            this.btn_ja.BackColor = System.Drawing.Color.White;
            this.btn_ja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ja.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ja.ForeColor = System.Drawing.Color.Black;
            this.btn_ja.Location = new System.Drawing.Point(1070, 499);
            this.btn_ja.Name = "btn_ja";
            this.btn_ja.Size = new System.Drawing.Size(448, 164);
            this.btn_ja.TabIndex = 2;
            this.btn_ja.Text = "Ja";
            this.btn_ja.UseVisualStyleBackColor = false;
            this.btn_ja.Click += new System.EventHandler(this.btn_ja_Click);
            this.btn_ja.MouseEnter += new System.EventHandler(this.genHoverButton);
            this.btn_ja.MouseLeave += new System.EventHandler(this.restoreHoverButton);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.checkBox3.Font = new System.Drawing.Font("Arial", 72F);
            this.checkBox3.ForeColor = System.Drawing.Color.Yellow;
            this.checkBox3.Location = new System.Drawing.Point(292, 376);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(1221, 110);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Spelers invoeren";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.Visible = false;
            // 
            // chkSpelersInvoeren
            // 
            this.chkSpelersInvoeren.BackColor = System.Drawing.Color.White;
            this.chkSpelersInvoeren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkSpelersInvoeren.Location = new System.Drawing.Point(176, 148);
            this.chkSpelersInvoeren.Name = "chkSpelersInvoeren";
            this.chkSpelersInvoeren.Size = new System.Drawing.Size(110, 110);
            this.chkSpelersInvoeren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chkSpelersInvoeren.TabIndex = 6;
            this.chkSpelersInvoeren.TabStop = false;
            this.chkSpelersInvoeren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // lbl_spelers_invoeren
            // 
            this.lbl_spelers_invoeren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lbl_spelers_invoeren.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spelers_invoeren.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_spelers_invoeren.Location = new System.Drawing.Point(292, 148);
            this.lbl_spelers_invoeren.Name = "lbl_spelers_invoeren";
            this.lbl_spelers_invoeren.Size = new System.Drawing.Size(1221, 110);
            this.lbl_spelers_invoeren.TabIndex = 7;
            this.lbl_spelers_invoeren.Text = "Spelers Invoeren";
            this.lbl_spelers_invoeren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_spelers_invoeren.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_spelers_invoeren.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_spelers_invoeren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // lbl_buerten_automatisch
            // 
            this.lbl_buerten_automatisch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lbl_buerten_automatisch.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buerten_automatisch.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_buerten_automatisch.Location = new System.Drawing.Point(292, 262);
            this.lbl_buerten_automatisch.Name = "lbl_buerten_automatisch";
            this.lbl_buerten_automatisch.Size = new System.Drawing.Size(1221, 110);
            this.lbl_buerten_automatisch.TabIndex = 8;
            this.lbl_buerten_automatisch.Text = "Beurten Automatisch";
            this.lbl_buerten_automatisch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_buerten_automatisch.Click += new System.EventHandler(this.lbl_buerten_automatisch_Click);
            this.lbl_buerten_automatisch.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_buerten_automatisch.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_buerten_automatisch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_buerten_automatisch_MouseUp);
            // 
            // chk_auto_beurten
            // 
            this.chk_auto_beurten.BackColor = System.Drawing.Color.White;
            this.chk_auto_beurten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chk_auto_beurten.Location = new System.Drawing.Point(176, 262);
            this.chk_auto_beurten.Name = "chk_auto_beurten";
            this.chk_auto_beurten.Size = new System.Drawing.Size(110, 110);
            this.chk_auto_beurten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chk_auto_beurten.TabIndex = 9;
            this.chk_auto_beurten.TabStop = false;
            this.chk_auto_beurten.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // txtP1Name
            // 
            this.txtP1Name.BackColor = System.Drawing.Color.White;
            this.txtP1Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP1Name.Font = new System.Drawing.Font("Arial", 72F);
            this.txtP1Name.ForeColor = System.Drawing.Color.Black;
            this.txtP1Name.Location = new System.Drawing.Point(164, 776);
            this.txtP1Name.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtP1Name.Name = "txtP1Name";
            this.txtP1Name.Size = new System.Drawing.Size(770, 118);
            this.txtP1Name.TabIndex = 10;
            this.txtP1Name.Visible = false;
            this.txtP1Name.Enter += new System.EventHandler(this.Name_Enter);
            this.txtP1Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // txtP1Caroms
            // 
            this.txtP1Caroms.BackColor = System.Drawing.Color.White;
            this.txtP1Caroms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP1Caroms.Font = new System.Drawing.Font("Arial", 72F);
            this.txtP1Caroms.ForeColor = System.Drawing.Color.Black;
            this.txtP1Caroms.Location = new System.Drawing.Point(941, 776);
            this.txtP1Caroms.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtP1Caroms.MaxLength = 3;
            this.txtP1Caroms.Name = "txtP1Caroms";
            this.txtP1Caroms.Size = new System.Drawing.Size(250, 118);
            this.txtP1Caroms.TabIndex = 11;
            this.txtP1Caroms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP1Caroms.Visible = false;
            this.txtP1Caroms.Enter += new System.EventHandler(this.Name_Enter);
            this.txtP1Caroms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP1Caroms_KeyPress);
            this.txtP1Caroms.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // txtP2Caroms
            // 
            this.txtP2Caroms.BackColor = System.Drawing.Color.White;
            this.txtP2Caroms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP2Caroms.Font = new System.Drawing.Font("Arial", 72F);
            this.txtP2Caroms.ForeColor = System.Drawing.Color.Black;
            this.txtP2Caroms.Location = new System.Drawing.Point(941, 903);
            this.txtP2Caroms.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtP2Caroms.MaxLength = 3;
            this.txtP2Caroms.Name = "txtP2Caroms";
            this.txtP2Caroms.Size = new System.Drawing.Size(250, 118);
            this.txtP2Caroms.TabIndex = 13;
            this.txtP2Caroms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP2Caroms.Visible = false;
            this.txtP2Caroms.Enter += new System.EventHandler(this.Name_Enter);
            this.txtP2Caroms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP2Caroms_KeyPress);
            this.txtP2Caroms.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // txtP2Name
            // 
            this.txtP2Name.BackColor = System.Drawing.Color.White;
            this.txtP2Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtP2Name.Font = new System.Drawing.Font("Arial", 72F);
            this.txtP2Name.ForeColor = System.Drawing.Color.Black;
            this.txtP2Name.Location = new System.Drawing.Point(164, 903);
            this.txtP2Name.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.txtP2Name.Name = "txtP2Name";
            this.txtP2Name.Size = new System.Drawing.Size(770, 118);
            this.txtP2Name.TabIndex = 12;
            this.txtP2Name.Visible = false;
            this.txtP2Name.Enter += new System.EventHandler(this.Name_Enter);
            this.txtP2Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // btnP2Start
            // 
            this.btnP2Start.BackColor = System.Drawing.Color.White;
            this.btnP2Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP2Start.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP2Start.ForeColor = System.Drawing.Color.Black;
            this.btnP2Start.Location = new System.Drawing.Point(1198, 903);
            this.btnP2Start.Name = "btnP2Start";
            this.btnP2Start.Size = new System.Drawing.Size(448, 118);
            this.btnP2Start.TabIndex = 14;
            this.btnP2Start.Text = "Begint";
            this.btnP2Start.UseVisualStyleBackColor = false;
            this.btnP2Start.Visible = false;
            this.btnP2Start.Click += new System.EventHandler(this.btnP2Start_Click);
            this.btnP2Start.MouseEnter += new System.EventHandler(this.genHoverButton);
            this.btnP2Start.MouseLeave += new System.EventHandler(this.restoreHoverButton);
            // 
            // btnP1Start
            // 
            this.btnP1Start.BackColor = System.Drawing.Color.White;
            this.btnP1Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP1Start.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP1Start.ForeColor = System.Drawing.Color.Black;
            this.btnP1Start.Location = new System.Drawing.Point(1198, 776);
            this.btnP1Start.Name = "btnP1Start";
            this.btnP1Start.Size = new System.Drawing.Size(448, 118);
            this.btnP1Start.TabIndex = 15;
            this.btnP1Start.Text = "Begint";
            this.btnP1Start.UseVisualStyleBackColor = false;
            this.btnP1Start.Visible = false;
            this.btnP1Start.Click += new System.EventHandler(this.btnP1Start_Click);
            this.btnP1Start.MouseEnter += new System.EventHandler(this.genHoverButton);
            this.btnP1Start.MouseLeave += new System.EventHandler(this.restoreHoverButton);
            // 
            // lblExitApplication
            // 
            this.lblExitApplication.Location = new System.Drawing.Point(1710, 2);
            this.lblExitApplication.Name = "lblExitApplication";
            this.lblExitApplication.Size = new System.Drawing.Size(207, 23);
            this.lblExitApplication.TabIndex = 16;
            this.lblExitApplication.Text = "      ";
            this.lblExitApplication.Click += new System.EventHandler(this.lblExitApplication_Click);
            this.lblExitApplication.DoubleClick += new System.EventHandler(this.lblExitApplication_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1587, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 84);
            this.button1.TabIndex = 17;
            this.button1.Text = "Afsluiten";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblNaam
            // 
            this.LblNaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.LblNaam.Font = new System.Drawing.Font("Arial", 48F);
            this.LblNaam.ForeColor = System.Drawing.Color.Yellow;
            this.LblNaam.Location = new System.Drawing.Point(164, 688);
            this.LblNaam.Name = "LblNaam";
            this.LblNaam.Size = new System.Drawing.Size(770, 81);
            this.LblNaam.TabIndex = 18;
            this.LblNaam.Text = "Naam";
            this.LblNaam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblNaam.Visible = false;
            // 
            // LblMaken
            // 
            this.LblMaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.LblMaken.Font = new System.Drawing.Font("Arial", 48F);
            this.LblMaken.ForeColor = System.Drawing.Color.Yellow;
            this.LblMaken.Location = new System.Drawing.Point(940, 688);
            this.LblMaken.Name = "LblMaken";
            this.LblMaken.Size = new System.Drawing.Size(251, 81);
            this.LblMaken.TabIndex = 19;
            this.LblMaken.Text = "Maken";
            this.LblMaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMaken.Visible = false;
            // 
            // LblBeginnen
            // 
            this.LblBeginnen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.LblBeginnen.Font = new System.Drawing.Font("Arial", 48F);
            this.LblBeginnen.ForeColor = System.Drawing.Color.Yellow;
            this.LblBeginnen.Location = new System.Drawing.Point(1198, 688);
            this.LblBeginnen.Name = "LblBeginnen";
            this.LblBeginnen.Size = new System.Drawing.Size(448, 81);
            this.LblBeginnen.TabIndex = 20;
            this.LblBeginnen.Text = "Beginnen";
            this.LblBeginnen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblBeginnen.Visible = false;
            // 
            // NieuwePartij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.LblBeginnen);
            this.Controls.Add(this.LblMaken);
            this.Controls.Add(this.LblNaam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblExitApplication);
            this.Controls.Add(this.btnP1Start);
            this.Controls.Add(this.btnP2Start);
            this.Controls.Add(this.txtP2Caroms);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.txtP1Caroms);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.chk_auto_beurten);
            this.Controls.Add(this.lbl_buerten_automatisch);
            this.Controls.Add(this.lbl_spelers_invoeren);
            this.Controls.Add(this.chkSpelersInvoeren);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.btn_ja);
            this.Controls.Add(this.btn_nee);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NieuwePartij";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NieuwePartij";
            this.Load += new System.EventHandler(this.NieuwePartij_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkSpelersInvoeren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_auto_beurten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nee;
        private System.Windows.Forms.Button btn_ja;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox chkSpelersInvoeren;
        private System.Windows.Forms.Label lbl_spelers_invoeren;
        private System.Windows.Forms.Label lbl_buerten_automatisch;
        private System.Windows.Forms.PictureBox chk_auto_beurten;
        private System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.TextBox txtP1Caroms;
        private System.Windows.Forms.TextBox txtP2Caroms;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.Button btnP2Start;
        private System.Windows.Forms.Button btnP1Start;
        private System.Windows.Forms.Label lblExitApplication;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblNaam;
        private System.Windows.Forms.Label LblMaken;
        private System.Windows.Forms.Label LblBeginnen;
    }
}