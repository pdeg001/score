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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.lblP1NameLocal = new System.Windows.Forms.Label();
            this.lblP2NameLocal = new System.Windows.Forms.Label();
            this.lblP3NameLocal = new System.Windows.Forms.Label();
            this.lblP4NameLocal = new System.Windows.Forms.Label();
            this.lblP1NameUit = new System.Windows.Forms.Label();
            this.lblP2NameUit = new System.Windows.Forms.Label();
            this.lblP3NameUit = new System.Windows.Forms.Label();
            this.lblP4NameUit = new System.Windows.Forms.Label();
            this.lblClub1Name = new System.Windows.Forms.Label();
            this.lblClub2Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btn_continue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.ForeColor = System.Drawing.Color.Black;
            this.btn_continue.Location = new System.Drawing.Point(1427, 834);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(448, 164);
            this.btn_continue.TabIndex = 3;
            this.btn_continue.Text = "Verder";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // lblP1NameLocal
            // 
            this.lblP1NameLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP1NameLocal.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP1NameLocal.ForeColor = System.Drawing.Color.Yellow;
            this.lblP1NameLocal.Location = new System.Drawing.Point(0, 263);
            this.lblP1NameLocal.Name = "lblP1NameLocal";
            this.lblP1NameLocal.Size = new System.Drawing.Size(767, 110);
            this.lblP1NameLocal.TabIndex = 4;
            this.lblP1NameLocal.Tag = "p1Make";
            this.lblP1NameLocal.Text = "Peter de Groot";
            this.lblP1NameLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP1NameLocal.UseCompatibleTextRendering = true;
            this.lblP1NameLocal.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP1NameLocal.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP1NameLocal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblP2NameLocal
            // 
            this.lblP2NameLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP2NameLocal.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP2NameLocal.ForeColor = System.Drawing.Color.Yellow;
            this.lblP2NameLocal.Location = new System.Drawing.Point(0, 380);
            this.lblP2NameLocal.Name = "lblP2NameLocal";
            this.lblP2NameLocal.Size = new System.Drawing.Size(767, 110);
            this.lblP2NameLocal.TabIndex = 4;
            this.lblP2NameLocal.Tag = "p2HomeColor";
            this.lblP2NameLocal.Text = "Piet Oudeman";
            this.lblP2NameLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP2NameLocal.UseCompatibleTextRendering = true;
            this.lblP2NameLocal.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP2NameLocal.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP2NameLocal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblP3NameLocal
            // 
            this.lblP3NameLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP3NameLocal.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP3NameLocal.ForeColor = System.Drawing.Color.Yellow;
            this.lblP3NameLocal.Location = new System.Drawing.Point(0, 497);
            this.lblP3NameLocal.Name = "lblP3NameLocal";
            this.lblP3NameLocal.Size = new System.Drawing.Size(767, 110);
            this.lblP3NameLocal.TabIndex = 4;
            this.lblP3NameLocal.Tag = "p3HomeColor";
            this.lblP3NameLocal.Text = "Speler 3";
            this.lblP3NameLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP3NameLocal.UseCompatibleTextRendering = true;
            this.lblP3NameLocal.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP3NameLocal.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP3NameLocal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblP4NameLocal
            // 
            this.lblP4NameLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP4NameLocal.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP4NameLocal.ForeColor = System.Drawing.Color.Yellow;
            this.lblP4NameLocal.Location = new System.Drawing.Point(0, 614);
            this.lblP4NameLocal.Name = "lblP4NameLocal";
            this.lblP4NameLocal.Size = new System.Drawing.Size(767, 110);
            this.lblP4NameLocal.TabIndex = 4;
            this.lblP4NameLocal.Tag = "p4HomeColor";
            this.lblP4NameLocal.Text = "Speler 4";
            this.lblP4NameLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP4NameLocal.UseCompatibleTextRendering = true;
            this.lblP4NameLocal.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP4NameLocal.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP4NameLocal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblP1NameUit
            // 
            this.lblP1NameUit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP1NameUit.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP1NameUit.ForeColor = System.Drawing.Color.Yellow;
            this.lblP1NameUit.Location = new System.Drawing.Point(1160, 263);
            this.lblP1NameUit.Name = "lblP1NameUit";
            this.lblP1NameUit.Size = new System.Drawing.Size(759, 110);
            this.lblP1NameUit.TabIndex = 4;
            this.lblP1NameUit.Tag = "p1VisitColor";
            this.lblP1NameUit.Text = "Speler 1";
            this.lblP1NameUit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP1NameUit.UseCompatibleTextRendering = true;
            this.lblP1NameUit.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP1NameUit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP1NameUit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblP2NameUit
            // 
            this.lblP2NameUit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP2NameUit.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP2NameUit.ForeColor = System.Drawing.Color.Yellow;
            this.lblP2NameUit.Location = new System.Drawing.Point(1160, 380);
            this.lblP2NameUit.Name = "lblP2NameUit";
            this.lblP2NameUit.Size = new System.Drawing.Size(759, 110);
            this.lblP2NameUit.TabIndex = 4;
            this.lblP2NameUit.Tag = "p2VisitColor";
            this.lblP2NameUit.Text = "Speler 2";
            this.lblP2NameUit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP2NameUit.UseCompatibleTextRendering = true;
            this.lblP2NameUit.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP2NameUit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP2NameUit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblP3NameUit
            // 
            this.lblP3NameUit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP3NameUit.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP3NameUit.ForeColor = System.Drawing.Color.Yellow;
            this.lblP3NameUit.Location = new System.Drawing.Point(1160, 497);
            this.lblP3NameUit.Name = "lblP3NameUit";
            this.lblP3NameUit.Size = new System.Drawing.Size(759, 110);
            this.lblP3NameUit.TabIndex = 4;
            this.lblP3NameUit.Tag = "p3VisitColor";
            this.lblP3NameUit.Text = "Speler 3";
            this.lblP3NameUit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP3NameUit.UseCompatibleTextRendering = true;
            this.lblP3NameUit.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP3NameUit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP3NameUit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
            // 
            // lblP4NameUit
            // 
            this.lblP4NameUit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(83)))));
            this.lblP4NameUit.Font = new System.Drawing.Font("Arial", 52F);
            this.lblP4NameUit.ForeColor = System.Drawing.Color.Yellow;
            this.lblP4NameUit.Location = new System.Drawing.Point(1160, 614);
            this.lblP4NameUit.Name = "lblP4NameUit";
            this.lblP4NameUit.Size = new System.Drawing.Size(759, 110);
            this.lblP4NameUit.TabIndex = 4;
            this.lblP4NameUit.Tag = "p4VisitColor";
            this.lblP4NameUit.Text = "S. v Duivenvoorde";
            this.lblP4NameUit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP4NameUit.UseCompatibleTextRendering = true;
            this.lblP4NameUit.MouseEnter += new System.EventHandler(this.GenHover);
            this.lblP4NameUit.MouseLeave += new System.EventHandler(this.RestoreHover);
            this.lblP4NameUit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayerClicked);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial", 64F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(773, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 110);
            this.label2.TabIndex = 4;
            this.label2.Text = "39";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Arial", 64F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(773, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 110);
            this.label3.TabIndex = 4;
            this.label3.Text = "26";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Arial", 64F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(773, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 110);
            this.label4.TabIndex = 4;
            this.label4.Text = "44";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Arial", 64F);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(773, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 110);
            this.label5.TabIndex = 4;
            this.label5.Text = "29";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Arial", 64F);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(970, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 110);
            this.label6.TabIndex = 4;
            this.label6.Text = "39";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Arial", 64F);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(970, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 110);
            this.label7.TabIndex = 4;
            this.label7.Text = "26";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Arial", 64F);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(970, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 110);
            this.label8.TabIndex = 4;
            this.label8.Text = "44";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Arial", 64F);
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(970, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 110);
            this.label9.TabIndex = 4;
            this.label9.Text = "291";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.UseCompatibleTextRendering = true;
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
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(962, 834);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(448, 164);
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
            this.button1.Location = new System.Drawing.Point(497, 834);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 164);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sluit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeamenSelectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.lblP4NameUit);
            this.Controls.Add(this.lblP4NameLocal);
            this.Controls.Add(this.lblP3NameUit);
            this.Controls.Add(this.lblP3NameLocal);
            this.Controls.Add(this.lblP2NameUit);
            this.Controls.Add(this.lblP2NameLocal);
            this.Controls.Add(this.lblP1NameUit);
            this.Controls.Add(this.lblClub2Name);
            this.Controls.Add(this.lblClub1Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblP1NameLocal);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label lblP1NameLocal;
        private System.Windows.Forms.Label lblP2NameLocal;
        private System.Windows.Forms.Label lblP3NameLocal;
        private System.Windows.Forms.Label lblP4NameLocal;
        private System.Windows.Forms.Label lblP1NameUit;
        private System.Windows.Forms.Label lblP2NameUit;
        private System.Windows.Forms.Label lblP3NameUit;
        private System.Windows.Forms.Label lblP4NameUit;
        private System.Windows.Forms.Label lblClub1Name;
        private System.Windows.Forms.Label lblClub2Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button1;
    }
}