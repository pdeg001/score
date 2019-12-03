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

namespace peter
{
    public partial class Form1 : Form
    {
        public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
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
            double test = 0000;
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
           
            Console.WriteLine(carom);

            PadStr padstr = new PadStr();
            padstr.carom = carom;
            newCarom = padstr.GenPad();
            points = lblVal + carom;
            lbl1.Text = newCarom.Substring(3, 1);
            lbl10.Text = newCarom.Substring(2, 1);
            lbl100.Text = newCarom.Substring(1, 1);
            lbl1000.Text = newCarom.Substring(0, 1);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string fileName = lbl.Text+".png";
            string path = Path.Combine(projectDirectory, @"images\", fileName);
            Image img = Image.FromFile(path);
         //   pic_p1_1000.Image = img; // Image.FromFile(path);
            PictureBox pic;
            pic = Controls.Find("pic_" + playerNumber + "_" + pointsPassed, true).FirstOrDefault() as PictureBox;
            pic.Image = img;
            pic.Tag = lbl.Text;
            //pic_p1_1

        }


        private void Form1_MouseDownImgClick(object sender, MouseEventArgs e)
        {
            int carom = 0;
            string padCarom = "";

            PictureBox pic = sender as PictureBox;
            string picName = pic.Name;
            string[] picNameSplit = picName.Split('_');
            string player = picNameSplit.GetValue(1).ToString();
            int passedValue = Int32.Parse(picNameSplit.GetValue(2).ToString());

            PictureBox pic1000 = Controls.Find("pic_" + player + "_1000", true).FirstOrDefault() as PictureBox;
            PictureBox pic100 = Controls.Find("pic_" + player + "_100", true).FirstOrDefault() as PictureBox;
            PictureBox pic10 = Controls.Find("pic_" + player + "_10", true).FirstOrDefault() as PictureBox;
            PictureBox pic1 = Controls.Find("pic_" + player + "_1", true).FirstOrDefault() as PictureBox;

            string p1Carom = pic1000.Tag.ToString() + pic100.Tag.ToString() + pic10.Tag.ToString() + pic1.Tag.ToString();
            carom = Int32.Parse(p1Carom);
            if (e.Button == MouseButtons.Left)
            {
                carom += passedValue;

                if (carom > 9999)
                {
                    return;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                carom -= passedValue;
                if (carom <= -1)
                {
                    return;
                }

            }

            PadStr padstr = new PadStr();
            padstr.carom = carom;
            string newCarom = padstr.GenPad();

            pic1000.Tag = newCarom.Substring(0, 1);
            pic100.Tag = newCarom.Substring(1, 1);
            pic10.Tag = newCarom.Substring(2, 1);
            pic1.Tag = newCarom.Substring(3, 1);
            GetNumPic numpic = new GetNumPic();
            numpic.imgName = pic1.Tag.ToString() + ".png";
            pic1.Image = numpic.getPic();
            numpic.imgName = pic10.Tag.ToString() + ".png";
            pic10.Image = numpic.getPic();
            numpic.imgName = pic100.Tag.ToString() + ".png";
            pic100.Image = numpic.getPic();
            numpic.imgName = pic1000.Tag.ToString() + ".png";
            pic1000.Image = numpic.getPic();
        }

        class PadStr
        {
            public int carom = 0;
                 public string GenPad()
            {
                return carom.ToString().PadLeft(4, '0');
            }

        }


        class GetNumPic
        {
            public string imgName = "";
            public Image img; 
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            public Image getPic()
            {
                
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", imgName));
            }
        }
    }
}
