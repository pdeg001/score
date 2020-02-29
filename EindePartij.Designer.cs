namespace peter
{
    partial class EindePartij
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
            this.btn_ja = new System.Windows.Forms.Button();
            this.btn_nee = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(343, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1259, 173);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wilt u de partij beëindigen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ja
            // 
            this.btn_ja.BackColor = System.Drawing.Color.White;
            this.btn_ja.FlatAppearance.BorderSize = 0;
            this.btn_ja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ja.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ja.Location = new System.Drawing.Point(1154, 374);
            this.btn_ja.Name = "btn_ja";
            this.btn_ja.Size = new System.Drawing.Size(448, 164);
            this.btn_ja.TabIndex = 4;
            this.btn_ja.Text = "Ja";
            this.btn_ja.UseVisualStyleBackColor = false;
            this.btn_ja.Click += new System.EventHandler(this.btn_ja_Click);
            this.btn_ja.MouseEnter += new System.EventHandler(this.genHoverButton);
            this.btn_ja.MouseLeave += new System.EventHandler(this.restoreHoverButton);
            // 
            // btn_nee
            // 
            this.btn_nee.BackColor = System.Drawing.Color.White;
            this.btn_nee.FlatAppearance.BorderSize = 0;
            this.btn_nee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nee.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nee.ForeColor = System.Drawing.Color.Black;
            this.btn_nee.Location = new System.Drawing.Point(343, 374);
            this.btn_nee.Name = "btn_nee";
            this.btn_nee.Size = new System.Drawing.Size(448, 164);
            this.btn_nee.TabIndex = 3;
            this.btn_nee.Text = "Nee";
            this.btn_nee.UseVisualStyleBackColor = false;
            this.btn_nee.Click += new System.EventHandler(this.btn_nee_Click);
            this.btn_nee.MouseEnter += new System.EventHandler(this.genHoverButton);
            this.btn_nee.MouseLeave += new System.EventHandler(this.restoreHoverButton);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(460, 111);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Afsluiten";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // EindePartij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(1)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_ja);
            this.Controls.Add(this.btn_nee);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EindePartij";
            this.Text = "EindePartij";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ja;
        private System.Windows.Forms.Button btn_nee;
        private System.Windows.Forms.Button btnClose;
    }
}