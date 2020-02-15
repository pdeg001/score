using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;


//TODO: add function comment for all classes

namespace peter
{
    class ClsBord
    {
        public Label lbl1;
        public Label lblMake1;
        public Label lbl10;
        public Label lblMake10;
        public Label lbl100;
        public Label lblMake100;
        public Label lblMoyenne;
        public Label lblPercentage;
        
        public ProgressBar progressBar;

        public int caroms;
        public double avg;
        

        public void ResetBoard()
        {

            //PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            //privateFontCollection.AddFontFile(Functions.GetFontFile());

            lbl1.Text           = "0";
            lbl10.Text          = "0";
            lbl100.Text         = "0";
            lblMake1.Text       = "0";
            lblMake10.Text      = "0";
            lblMake100.Text     = "0";
            lblPercentage.Text  = "0.000 %";
            lblMoyenne.Text     = "0.000";
            progressBar.Value   = 0;

            //lbl1.Font = new Font(privateFontCollection.Families[0], 250);
            //lbl10.Font = new Font(privateFontCollection.Families[0], 250);
            //lbl100.Font = new Font(privateFontCollection.Families[0], 250);
            //lblMake1.Font = new Font(privateFontCollection.Families[0], 180);
            //lblMake10.Font = new Font(privateFontCollection.Families[0], 180);
            //lblMake100.Font = new Font(privateFontCollection.Families[0], 180);


            caroms = 0;
            avg = 0.0;
        }

        public void SetCaramBoles(Boolean LeftMouse, int Value)
        {
            if (LeftMouse == false)
            {
                Value = -Math.Abs(Value);
            }

            int currCaram = CalcCaram();
            currCaram += Value;
            if (currCaram <= 999 && currCaram > -1)
            {
                SetNewCaram(Functions.GenPadding(currCaram));
                ProcesScore.CalcMoyenne(currCaram);
                caroms = currCaram;
            }
        }

        private int CalcCaram()
        {
            return Convert.ToInt32(lbl100.Text + lbl10.Text+lbl1.Text);
        }

        public void SetMake(Boolean LeftMouse, int Value)
        {
            if (LeftMouse == false)
            {
                Value = -Math.Abs(Value);
            }

            int currMake = CalcMake();
            currMake += Value;

            if (currMake <= 999 && currMake >= 0)
            {
                SetNewMake(Functions.GenPadding(currMake));
            }
        }

        private int CalcMake()
        {
            return Convert.ToInt32(lblMake100.Text + lblMake10.Text + lblMake1.Text);
        }

        private void SetNewMake(string newMake)
        {
            lblMake1.Text = newMake.Substring(2, 1);
            lblMake10.Text = newMake.Substring(1, 1);
            lblMake100.Text = newMake.Substring(0, 1);
        }

        private void SetNewCaram(string newCaram)
        {
                lbl1.Text = newCaram.Substring(2, 1);
                lbl10.Text = newCaram.Substring(1, 1);
                lbl100.Text = newCaram.Substring(0, 1);
        }

        public void SetFontFamily()
        {
        }

      public void CalcMoyenne() 
        {
            double caroms;
            double Innings = ClsInnings.inningsCount;
            string mMoyenne;

            caroms = CalcCaram();

            if (Innings > 0 && caroms > 0)
            {
                double moyenne = caroms / Innings;
                moyenne = Math.Truncate(moyenne * 1000) / 1000;
                mMoyenne = string.Format("{0:0.000}", moyenne);
                lblMoyenne.Text = mMoyenne.Replace(",", ".");
                CalcPercentage();
            }
        }

        public void CalcPercentage()
        {
            double percentage;
            double mCarom, mMake;
            string mPerc;

            mCarom = caroms;
            mMake = CalcMake();

            percentage = (mCarom / mMake) * 100;

            if (percentage > 100)
                return;
            mPerc = string.Format("{0:0.000} %", percentage);
            
            lblPercentage.Text = mPerc.Replace(",", ".");
            progressBar.Value = Convert.ToInt32(percentage);
        }


        public void EnableMakeHover()
        {
            lblMake1.MouseEnter += new EventHandler(genHover);
            lblMake1.MouseLeave += new EventHandler(restoreHover);
            lblMake10.MouseEnter += new EventHandler(genHover);
            lblMake10.MouseLeave += new EventHandler(restoreHover); 
            lblMake100.MouseEnter += new EventHandler(genHover);
            lblMake100.MouseLeave += new EventHandler(restoreHover);
        }

        public void DisableMakeHover()
        {
            lblMake1.MouseEnter -= new EventHandler(genHover);
            lblMake1.MouseLeave -= new EventHandler(restoreHover);
            lblMake10.MouseEnter -= new EventHandler(genHover);
            lblMake10.MouseLeave -= new EventHandler(restoreHover);
            lblMake100.MouseEnter -= new EventHandler(genHover);
            lblMake100.MouseLeave -= new EventHandler(restoreHover);
        }
        
        public void EnableCaromHover()
        {
            lbl1.MouseEnter += new EventHandler(genHover);
            lbl1.MouseLeave += new EventHandler(restoreHover);
            lbl10.MouseEnter += new EventHandler(genHover);
            lbl10.MouseLeave += new EventHandler(restoreHover);
            lbl100.MouseEnter += new EventHandler(genHover);
            lbl100.MouseLeave += new EventHandler(restoreHover);
        }

        public void DisableCaromHover()
        {
            lbl1.MouseEnter -= new EventHandler(genHover);
            lbl1.MouseLeave -= new EventHandler(restoreHover);
            lbl10.MouseEnter -= new EventHandler(genHover);
            lbl10.MouseLeave -= new EventHandler(restoreHover);
            lbl100.MouseEnter -= new EventHandler(genHover);
            lbl100.MouseLeave -= new EventHandler(restoreHover);
        }

        private void genHover(object sender, EventArgs e)
        {
           
            Label lbl = sender as Label;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF"); //System.Drawing.Color.LightBlue;
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void restoreHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");//#FF00FF System.Drawing.Color.Blue;
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

    } 
}

