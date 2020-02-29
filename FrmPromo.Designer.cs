namespace peter
{
    partial class FrmPromo
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
            this.ImgHeader = new System.Windows.Forms.PictureBox();
            this.LblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgHeader
            // 
            this.ImgHeader.Location = new System.Drawing.Point(0, 0);
            this.ImgHeader.Margin = new System.Windows.Forms.Padding(5);
            this.ImgHeader.Name = "ImgHeader";
            this.ImgHeader.Size = new System.Drawing.Size(985, 229);
            this.ImgHeader.TabIndex = 0;
            this.ImgHeader.TabStop = false;
            // 
            // LblText
            // 
            this.LblText.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.LblText.Location = new System.Drawing.Point(14, 234);
            this.LblText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(991, 380);
            this.LblText.TabIndex = 1;
            this.LblText.Text = "Test 1234";
            this.LblText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 615);
            this.ControlBox = false;
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.ImgHeader);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPromo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ImgHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgHeader;
        private System.Windows.Forms.Label LblText;
    }
}