using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace peter
{
    public class ClsInnings
    {
        public Label lblInnings;
        public Label lblInning1;
        public Label lblInning10;
        public Label lblInning100;

        public static int inningsCount;

        public void ResetInning()
         {
            if (Functions.osLinux)
            {
                PrivateFontCollection privateFontCollection = new PrivateFontCollection();
                privateFontCollection.AddFontFile(Functions.GetFontFile());
                lblInning1.Font = new Font(privateFontCollection.Families[0], 80);
                lblInning10.Font = new Font(privateFontCollection.Families[0], 80);
                lblInning100.Font = new Font(privateFontCollection.Families[0], 80);
                
                ScaleFont(lblInning100, 180);
                ScaleFont(lblInning10, 180);
                ScaleFont(lblInning1, 180);
            }

            lblInnings.Text = "001";
            lblInning1.Text = "1";
            lblInning10.Text = "0";
            lblInning100.Text = "0";
            inningsCount = 1;
        }

        public void setInnings(Boolean leftMouse)
        {
            int Value = inningsCount;// Convert.ToInt32($"{lblInning100.Text}{lblInning10.Text}{lblInning1.Text}"); //Convert.ToInt32(lblInnings.Text);

            if (leftMouse == false)
            {
                Value --;
            } else
            {
                Value ++;
            }
            if (Value >= 0)
            {
                inningsCount = Value;
                lblInnings.Text = Functions.GenPadding(Value);
                string _inning = inningsCount.ToString().PadLeft(3, '0');
                lblInning100.Text = _inning.Substring(0, 1);
                lblInning10.Text = _inning.Substring(1, 1);
                lblInning1.Text = _inning.Substring(2, 1);
            }


        }

        public static int RetInnings()
        {
            return inningsCount;
        }

        public void RestoreInnings(string inn)
        {
            int inning = int.Parse(inn);
            inningsCount = inning;
        }

        private void ScaleFont(Label lbl, int size)
        {
            // Only bother if there's text.
            string txt = lbl.Text;
            if (txt.Length > 0)
            {
                int best_size = size; // 180;

                // See how much room we have, allowing a bit
                // for the Label's internal margin.
                int wid = lbl.DisplayRectangle.Width - 3;
                int hgt = lbl.DisplayRectangle.Height - 3;

                // Make a Graphics object to measure the text.
                using (Graphics gr = lbl.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font =
                            new Font(lbl.Font.FontFamily, i))
                        {
                            // See how much space the text would
                            // need, specifying a maximum width.
                            SizeF text_size =
                                gr.MeasureString(txt, test_font);
                            if ((text_size.Width > wid) ||
                                (text_size.Height > hgt))
                            {
                                best_size = i - 1;
                                break;
                            }
                        }
                    }
                }

                // Use that font size.
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font(lbl.Font.FontFamily, best_size);
            }
        }
    }

}
