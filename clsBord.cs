using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peter
{
    class ClsBord
    {
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lblMake1;
        public System.Windows.Forms.Label lbl10;
        public System.Windows.Forms.Label lblMake10;
        public System.Windows.Forms.Label lblMake100;
        public System.Windows.Forms.Label lbl100;
        public int caroms;
        public double avg;


        public void ResetBoard()
        {
            lbl1.Text = "0";
            lbl10.Text = "0";
            lbl100.Text = "0";
            lblMake1.Text = "0";
            lblMake10.Text = "0";
            lblMake100.Text = "0";

          
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
            Console.WriteLine(value: currCaram);
            if (currCaram <= 999)
            {
                SetNewCaram(Functions.GenPadding(currCaram));
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

            if (currMake <= 999)
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
            lblMake1.Text = newMake.Substring(3, 1);
            lblMake10.Text = newMake.Substring(2, 1);
            lblMake100.Text = newMake.Substring(1, 1);
        }

        private void SetNewCaram(string newCaram)
        {
                lbl1.Text = newCaram.Substring(3, 1);
                lbl10.Text = newCaram.Substring(2, 1);
                lbl100.Text = newCaram.Substring(1, 1);
        }

        public void SetFontFamily()
        {
            //lbl1.Font = new System.Drawing.Font(digital-7 (mono).fa)
        }

      

    } 
}

