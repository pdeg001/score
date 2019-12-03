using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // private void Form1_MouseDown(object sender, EventArgs e)
        //{

        //}

        private void Form1_MouseDownCp1(object sender, MouseEventArgs e)
        {
            int lblVal = 0;
            int points = 0;
            int pointsPassed = 0;
            int carom = 0;
            string newCarom;
            string oldCarom;
            string labelPoints;
            string playerNumber;
            Label lbl1000, lbl100, lbl10, lbl1;

            Label lbl = sender as Label;
            object tag = lbl.Tag;


            string[] labelValue = lbl.Name.Split('_');
            pointsPassed = Int32.Parse(labelValue.GetValue(labelValue.Length-1).ToString());
            playerNumber = labelValue.GetValue(1).ToString();

            lbl1000 = Controls.Find("lbl_"+playerNumber+"_1000", true).FirstOrDefault() as Label;
            lbl100 = Controls.Find("lbl_"+playerNumber+"_100", true).FirstOrDefault() as Label;
            lbl10 = Controls.Find("lbl_"+playerNumber+"_10", true).FirstOrDefault() as Label;
            lbl1 = Controls.Find("lbl_"+playerNumber+"_1", true).FirstOrDefault() as Label;
          
            lblVal = Int32.Parse(lbl.Text);
            pointsPassed = Convert.ToInt32(lbl.Tag);
            oldCarom = lbl1000.Text + lbl100.Text + lbl10.Text + lbl1.Text;
            carom = Int32.Parse(oldCarom);


            if (e.Button == MouseButtons.Left)
            {
                carom += pointsPassed;

                if (carom > 9999)
                {
                    return;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                carom -= pointsPassed;
                if (carom <= -1)
                {
                    return;
                }

            }

            PadStr padstr = new PadStr();
            padstr.carom = carom;

            newCarom = padstr.GenPad();

            points = lblVal + carom;
            lbl1.Text = newCarom.Substring(3, 1);
            lbl10.Text = newCarom.Substring(2, 1);
            lbl100.Text = newCarom.Substring(1, 1);
            lbl1000.Text = newCarom.Substring(0, 1);
        
        }

        class PadStr
        {
            public int carom = 0;
                 public string GenPad()
            {
                return carom.ToString().PadLeft(4, '0');
            }

        }
    }
}
