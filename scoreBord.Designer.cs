namespace peter
{
    partial class SCORE_44
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
            this.lbl_exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.lbl_p1_moyenne = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblRealClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_exit
            // 
            this.lbl_exit.Location = new System.Drawing.Point(0, 0);
            this.lbl_exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(30, 19);
            this.lbl_exit.TabIndex = 5;
            this.lbl_exit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ExitApplication);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(761, 807);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caramboles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(709, 83);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speler 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1184, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(709, 83);
            this.label4.TabIndex = 6;
            this.label4.Text = "Speler 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_p1_car_1
            // 
            this.lbl_p1_car_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_p1_car_1.BackColor = System.Drawing.Color.Blue;
            this.lbl_p1_car_1.Font = new System.Drawing.Font("Arial", 200F);
            this.lbl_p1_car_1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p1_car_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p1_car_1.Location = new System.Drawing.Point(401, 327);
            this.lbl_p1_car_1.Name = "lbl_p1_car_1";
            this.lbl_p1_car_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p1_car_1.Size = new System.Drawing.Size(186, 255);
            this.lbl_p1_car_1.TabIndex = 8;
            this.lbl_p1_car_1.Tag = "1";
            this.lbl_p1_car_1.Text = "9";
            this.lbl_p1_car_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p1_car_1.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_p1_car_1.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_p1_car_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Caram);
            // 
            // lbl_p1_car_10
            // 
            this.lbl_p1_car_10.BackColor = System.Drawing.Color.Blue;
            this.lbl_p1_car_10.Font = new System.Drawing.Font("Arial", 200F);
            this.lbl_p1_car_10.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p1_car_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p1_car_10.Location = new System.Drawing.Point(203, 331);
            this.lbl_p1_car_10.Name = "lbl_p1_car_10";
            this.lbl_p1_car_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p1_car_10.Size = new System.Drawing.Size(180, 290);
            this.lbl_p1_car_10.TabIndex = 9;
            this.lbl_p1_car_10.Tag = "10";
            this.lbl_p1_car_10.Text = "4";
            this.lbl_p1_car_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p1_car_10.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_p1_car_10.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_p1_car_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Caram);
            // 
            // lbl_p1_car_100
            // 
            this.lbl_p1_car_100.BackColor = System.Drawing.Color.Blue;
            this.lbl_p1_car_100.Font = new System.Drawing.Font("Arial", 200F);
            this.lbl_p1_car_100.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p1_car_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p1_car_100.Location = new System.Drawing.Point(18, 331);
            this.lbl_p1_car_100.Name = "lbl_p1_car_100";
            this.lbl_p1_car_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p1_car_100.Size = new System.Drawing.Size(180, 290);
            this.lbl_p1_car_100.TabIndex = 10;
            this.lbl_p1_car_100.Tag = "100";
            this.lbl_p1_car_100.Text = "1";
            this.lbl_p1_car_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p1_car_100.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_p1_car_100.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_p1_car_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Caram);
            // 
            // lbl_p2_car_100
            // 
            this.lbl_p2_car_100.BackColor = System.Drawing.Color.Blue;
            this.lbl_p2_car_100.Font = new System.Drawing.Font("Arial", 200F);
            this.lbl_p2_car_100.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p2_car_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p2_car_100.Location = new System.Drawing.Point(1341, 331);
            this.lbl_p2_car_100.Name = "lbl_p2_car_100";
            this.lbl_p2_car_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p2_car_100.Size = new System.Drawing.Size(180, 290);
            this.lbl_p2_car_100.TabIndex = 13;
            this.lbl_p2_car_100.Tag = "100";
            this.lbl_p2_car_100.Text = "2";
            this.lbl_p2_car_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2_car_100.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_p2_car_100.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_p2_car_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Caram);
            // 
            // lbl_p2_car_10
            // 
            this.lbl_p2_car_10.BackColor = System.Drawing.Color.Blue;
            this.lbl_p2_car_10.Font = new System.Drawing.Font("Arial", 200F);
            this.lbl_p2_car_10.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p2_car_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p2_car_10.Location = new System.Drawing.Point(1525, 331);
            this.lbl_p2_car_10.Name = "lbl_p2_car_10";
            this.lbl_p2_car_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p2_car_10.Size = new System.Drawing.Size(180, 290);
            this.lbl_p2_car_10.TabIndex = 12;
            this.lbl_p2_car_10.Tag = "10";
            this.lbl_p2_car_10.Text = "3";
            this.lbl_p2_car_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2_car_10.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_p2_car_10.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_p2_car_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Caram);
            // 
            // lbl_p2_car_1
            // 
            this.lbl_p2_car_1.BackColor = System.Drawing.Color.Blue;
            this.lbl_p2_car_1.Font = new System.Drawing.Font("Arial", 200F);
            this.lbl_p2_car_1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_p2_car_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_p2_car_1.Location = new System.Drawing.Point(1709, 331);
            this.lbl_p2_car_1.Name = "lbl_p2_car_1";
            this.lbl_p2_car_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_p2_car_1.Size = new System.Drawing.Size(180, 290);
            this.lbl_p2_car_1.TabIndex = 11;
            this.lbl_p2_car_1.Tag = "1";
            this.lbl_p2_car_1.Text = "6";
            this.lbl_p2_car_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2_car_1.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_p2_car_1.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_p2_car_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Caram);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(772, 721);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(709, 67);
            this.label3.TabIndex = 14;
            this.label3.Text = "Caramboles";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // p1_make_100
            // 
            this.p1_make_100.BackColor = System.Drawing.Color.Blue;
            this.p1_make_100.Font = new System.Drawing.Font("Arial", 130F);
            this.p1_make_100.ForeColor = System.Drawing.Color.Yellow;
            this.p1_make_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1_make_100.Location = new System.Drawing.Point(60, 105);
            this.p1_make_100.Name = "p1_make_100";
            this.p1_make_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p1_make_100.Size = new System.Drawing.Size(170, 200);
            this.p1_make_100.TabIndex = 18;
            this.p1_make_100.Tag = "100";
            this.p1_make_100.Text = "1";
            this.p1_make_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1_make_100.MouseEnter += new System.EventHandler(this.genHover);
            this.p1_make_100.MouseLeave += new System.EventHandler(this.restoreHover);
            this.p1_make_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Make);
            // 
            // p1_make_10
            // 
            this.p1_make_10.BackColor = System.Drawing.Color.Blue;
            this.p1_make_10.Font = new System.Drawing.Font("Arial", 130F);
            this.p1_make_10.ForeColor = System.Drawing.Color.Yellow;
            this.p1_make_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1_make_10.Location = new System.Drawing.Point(234, 105);
            this.p1_make_10.Name = "p1_make_10";
            this.p1_make_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p1_make_10.Size = new System.Drawing.Size(170, 200);
            this.p1_make_10.TabIndex = 17;
            this.p1_make_10.Tag = "10";
            this.p1_make_10.Text = "4";
            this.p1_make_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1_make_10.MouseEnter += new System.EventHandler(this.genHover);
            this.p1_make_10.MouseLeave += new System.EventHandler(this.restoreHover);
            this.p1_make_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Make);
            // 
            // p1_make_1
            // 
            this.p1_make_1.BackColor = System.Drawing.Color.Blue;
            this.p1_make_1.Font = new System.Drawing.Font("Arial", 130F);
            this.p1_make_1.ForeColor = System.Drawing.Color.Yellow;
            this.p1_make_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p1_make_1.Location = new System.Drawing.Point(409, 105);
            this.p1_make_1.Name = "p1_make_1";
            this.p1_make_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p1_make_1.Size = new System.Drawing.Size(170, 200);
            this.p1_make_1.TabIndex = 16;
            this.p1_make_1.Tag = "1";
            this.p1_make_1.Text = "9";
            this.p1_make_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1_make_1.MouseEnter += new System.EventHandler(this.genHover);
            this.p1_make_1.MouseLeave += new System.EventHandler(this.restoreHover);
            this.p1_make_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P1Make);
            // 
            // p2_make_100
            // 
            this.p2_make_100.BackColor = System.Drawing.Color.Blue;
            this.p2_make_100.Font = new System.Drawing.Font("Arial", 130F);
            this.p2_make_100.ForeColor = System.Drawing.Color.Yellow;
            this.p2_make_100.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_100.Location = new System.Drawing.Point(1204, 105);
            this.p2_make_100.Name = "p2_make_100";
            this.p2_make_100.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p2_make_100.Size = new System.Drawing.Size(170, 200);
            this.p2_make_100.TabIndex = 21;
            this.p2_make_100.Tag = "100";
            this.p2_make_100.Text = "1";
            this.p2_make_100.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_100.MouseEnter += new System.EventHandler(this.genHover);
            this.p2_make_100.MouseLeave += new System.EventHandler(this.restoreHover);
            this.p2_make_100.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Make);
            // 
            // p2_make_10
            // 
            this.p2_make_10.BackColor = System.Drawing.Color.Blue;
            this.p2_make_10.Font = new System.Drawing.Font("Arial", 130F);
            this.p2_make_10.ForeColor = System.Drawing.Color.Yellow;
            this.p2_make_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_10.Location = new System.Drawing.Point(1379, 105);
            this.p2_make_10.Name = "p2_make_10";
            this.p2_make_10.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p2_make_10.Size = new System.Drawing.Size(170, 200);
            this.p2_make_10.TabIndex = 20;
            this.p2_make_10.Tag = "10";
            this.p2_make_10.Text = "4";
            this.p2_make_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2_make_10.MouseEnter += new System.EventHandler(this.genHover);
            this.p2_make_10.MouseLeave += new System.EventHandler(this.restoreHover);
            this.p2_make_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Make);
            // 
            // p2_make_1
            // 
            this.p2_make_1.BackColor = System.Drawing.Color.Blue;
            this.p2_make_1.Font = new System.Drawing.Font("Arial", 130F);
            this.p2_make_1.ForeColor = System.Drawing.Color.Yellow;
            this.p2_make_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.p2_make_1.Location = new System.Drawing.Point(1554, 105);
            this.p2_make_1.Name = "p2_make_1";
            this.p2_make_1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.p2_make_1.Size = new System.Drawing.Size(170, 200);
            this.p2_make_1.TabIndex = 19;
            this.p2_make_1.Tag = "1";
            this.p2_make_1.Text = "9";
            this.p2_make_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2_make_1.MouseEnter += new System.EventHandler(this.genHover);
            this.p2_make_1.MouseLeave += new System.EventHandler(this.restoreHover);
            this.p2_make_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P2Make);
            // 
            // lbl_bg
            // 
            this.lbl_bg.BackColor = System.Drawing.Color.Blue;
            this.lbl_bg.Font = new System.Drawing.Font("Arial", 130F);
            this.lbl_bg.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_bg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_bg.Location = new System.Drawing.Point(12, 105);
            this.lbl_bg.Name = "lbl_bg";
            this.lbl_bg.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_bg.Size = new System.Drawing.Size(1880, 540);
            this.lbl_bg.TabIndex = 22;
            this.lbl_bg.Tag = "100";
            this.lbl_bg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_innings
            // 
            this.lbl_innings.BackColor = System.Drawing.Color.Blue;
            this.lbl_innings.Font = new System.Drawing.Font("Arial", 200F);
            this.lbl_innings.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_innings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_innings.Location = new System.Drawing.Point(678, 355);
            this.lbl_innings.Name = "lbl_innings";
            this.lbl_innings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_innings.Size = new System.Drawing.Size(580, 255);
            this.lbl_innings.TabIndex = 23;
            this.lbl_innings.Tag = "1";
            this.lbl_innings.Text = "999";
            this.lbl_innings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_innings.MouseEnter += new System.EventHandler(this.genHover);
            this.lbl_innings.MouseLeave += new System.EventHandler(this.restoreHover);
            this.lbl_innings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SetInning);
            // 
            // lbl_p1_moyenne
            // 
            this.lbl_p1_moyenne.BackColor = System.Drawing.Color.Transparent;
            this.lbl_p1_moyenne.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_moyenne.ForeColor = System.Drawing.Color.Red;
            this.lbl_p1_moyenne.Location = new System.Drawing.Point(33, 690);
            this.lbl_p1_moyenne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_p1_moyenne.Name = "lbl_p1_moyenne";
            this.lbl_p1_moyenne.Size = new System.Drawing.Size(709, 67);
            this.lbl_p1_moyenne.TabIndex = 24;
            this.lbl_p1_moyenne.Text = "0.00";
            this.lbl_p1_moyenne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.TmrRealTime);
            // 
            // lblRealClock
            // 
            this.lblRealClock.BackColor = System.Drawing.Color.Transparent;
            this.lblRealClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Italic);
            this.lblRealClock.ForeColor = System.Drawing.Color.Red;
            this.lblRealClock.Location = new System.Drawing.Point(20, 894);
            this.lblRealClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRealClock.Name = "lblRealClock";
            this.lblRealClock.Size = new System.Drawing.Size(320, 67);
            this.lblRealClock.TabIndex = 25;
            this.lblRealClock.Text = "0.00";
            this.lblRealClock.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SCORE_44
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.lblRealClock);
            this.Controls.Add(this.lbl_p1_moyenne);
            this.Controls.Add(this.lbl_innings);
            this.Controls.Add(this.p2_make_100);
            this.Controls.Add(this.p2_make_10);
            this.Controls.Add(this.p2_make_1);
            this.Controls.Add(this.p1_make_100);
            this.Controls.Add(this.p1_make_10);
            this.Controls.Add(this.p1_make_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_p2_car_100);
            this.Controls.Add(this.lbl_p2_car_10);
            this.Controls.Add(this.lbl_p2_car_1);
            this.Controls.Add(this.lbl_p1_car_100);
            this.Controls.Add(this.lbl_p1_car_10);
            this.Controls.Add(this.lbl_p1_car_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SCORE_44";
            this.Text = "bord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label lbl_p1_moyenne;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblRealClock;
    }

    

}

