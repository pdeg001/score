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

namespace peter
{
    public class ClsInnings
    {
        public Label lblInnings;
        public static int inningsCount;

        public void ResetInning()
         {
            //  PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            //  privateFontCollection.AddFontFile(Functions.GetFontFile());

            //lblInnings.Font = new Font(privateFontCollection.Families[0], 225);
           
            lblInnings.Text = "001";
            inningsCount = 1;
        }

        public void setInnings(Boolean leftMouse)
        {
            int Value = Convert.ToInt32(lblInnings.Text);
                
            if(leftMouse == false)
            {
                Value --;
            } else
            {
                Value ++;
            }
            if (Value >= 0)
            {
                lblInnings.Text = Functions.GenPadding(Value);
            }

            inningsCount = Value;
        }

        public static int RetInnings()
        {
            return inningsCount;
        }
    }

}
