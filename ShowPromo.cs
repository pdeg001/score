using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace peter
{
    class ShowPromo
    {
        public static int promoX = 15;
        public static int promoY = 15;
        

        public static Panel pnPromo = new Panel();
        public static PictureBox picPromo = new PictureBox();
        public static Label lblText1 = new Label();
        public static Label lblText2 = new Label();
        public static Label lblText3 = new Label();
        public static Label lblText4 = new Label();
        public static Label lblText5 = new Label();



        public static Panel CreatePromoPanel()
        {
            pnPromo.Size = new System.Drawing.Size(990, 620);
            pnPromo.Location = new Point(35, 35);
            pnPromo.BorderStyle = BorderStyle.FixedSingle;
            pnPromo.BackColor = Color.White;

            picPromo.Size = new System.Drawing.Size(990, 230);
            picPromo.BackColor = Color.Transparent;
            picPromo.BorderStyle = BorderStyle.FixedSingle;
            picPromo.Image = Functions.GetPromoLogo();

            CreateTextLabel1(lblText1, 235);
            CreateTextLabel1(lblText2, lblText1.Bottom + 20);
            CreateTextLabel1(lblText3, lblText2.Bottom + 20);
            CreateTextLabel1(lblText4, lblText3.Bottom + 20);
            CreateTextLabel1(lblText5, lblText4.Bottom + 20);

            pnPromo.Controls.Add(picPromo);
            pnPromo.Controls.Add(lblText1);
            pnPromo.Controls.Add(lblText2);
            pnPromo.Controls.Add(lblText3);
            pnPromo.Controls.Add(lblText4);
            pnPromo.Controls.Add(lblText5);

            SetConfigVars();

            return pnPromo;

        }

        public static void ShowScreenSaver(Panel pnPromo)
        {
            //HORIZONTAL
            if (pnPromo.Left == 0 || pnPromo.Right == 1920)
                promoX = -promoX;

            if (promoX > 0)
                pnPromo.Left = Math.Min(pnPromo.Left + promoX, 1920 - pnPromo.Width);
            else
                pnPromo.Left = Math.Max(pnPromo.Left + promoX, 0);

            //GET PROMO TOP
            if (pnPromo.Top - 35 <= 0)
                promoY = Math.Abs(promoY);

            if (pnPromo.Bottom + 35 >= 1050)
                promoY = -Math.Abs(promoY);

            pnPromo.Top += promoY;
        }

        public static void CreateTextLabel1(object sender, int topPosition)
        {

            Label lbl = sender as Label;

            lbl.Size = new System.Drawing.Size(970, 55);
            lbl.Location = new Point(10, topPosition);
            lbl.BackColor = Color.White;
            lbl.Name = "lblPromoText";
            lbl.TextAlign = ContentAlignment.TopCenter;
            lbl.Font = new Font("Arial", 36);
            lbl.Text = "01234567890123456789012345678901234567890";

        }

        public static void SetConfigVars()
        {
            string json;
            FileStream cnfReader = new FileStream(Functions.GetConfigFile(), FileMode.Open, FileAccess.Read);
            using(StreamReader sr = new StreamReader(cnfReader))
            {
                json = sr.ReadToEnd().Replace("\"", "\'");
            }
            cnfReader.Close();

            var configLines = QuickType.Welcome.FromJson(json);

            lblText1.Text = configLines.Message.Line1;
            lblText2.Text = configLines.Message.Line2;
            lblText3.Text = configLines.Message.Line3;
            lblText4.Text = configLines.Message.Line4;
            lblText5.Text = configLines.Message.Line5;
        }
    }
}
