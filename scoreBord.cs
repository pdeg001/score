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
   
    public partial class SCORE_44 : Form
    {
        //public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public int p1Caromboles = 0;
        public int p2Caromboles = 0;
        ClsBord p1Bord = new ClsBord();
        ClsBord p2Bord = new ClsBord();

        public SCORE_44()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitBoard();
        }

        
        private void Form1_MouseDownCp1(object sender, MouseEventArgs e)
        {
        //    int lblVal = 0;
        //    int points = 0;
        //    int pointsPassed = 0;
        //    int carom = 0;
        //    double test = 0000;
        //    string newCarom;
        //    string oldCarom;
        //    string labelPoints;
        //    string playerNumber;
        //    Label lbl1000, lbl100, lbl10, lbl1;

        //    Label lbl = sender as Label;
        //    object tag = lbl.Tag;


        //    string[] labelValue = lbl.Name.Split('_');
        //    pointsPassed = Int32.Parse(labelValue.GetValue(labelValue.Length-1).ToString());
        //    playerNumber = labelValue.GetValue(1).ToString();

        //    lbl1000 = Controls.Find("lbl_"+playerNumber+"_1000", true).FirstOrDefault() as Label;
        //    lbl100 = Controls.Find("lbl_"+playerNumber+"_100", true).FirstOrDefault() as Label;
        //    lbl10 = Controls.Find("lbl_"+playerNumber+"_10", true).FirstOrDefault() as Label;
        //    lbl1 = Controls.Find("lbl_"+playerNumber+"_1", true).FirstOrDefault() as Label;
          
        //    lblVal = Int32.Parse(lbl.Text);
        //    pointsPassed = Convert.ToInt32(lbl.Tag);
        //    oldCarom = lbl1000.Text + lbl100.Text + lbl10.Text + lbl1.Text;
        //    carom = Int32.Parse(oldCarom);

        //    if (e.Button == MouseButtons.Left)
        //    {
        //        carom += pointsPassed;

        //        if (carom > 9999)
        //        {
        //            return;
        //        }
        //    }
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        carom -= pointsPassed;
        //        if (carom <= -1)
        //        {
        //            return;
        //        }

        //    }
           
        //    Console.WriteLine(carom);

        //    PadStr padstr = new PadStr();
        //    // padstr.carom = carom;
        //    newCarom = padstr.GenPad(carom);
        //    points = lblVal + carom;
        //    lbl1.Text = newCarom.Substring(3, 1);
        //    lbl10.Text = newCarom.Substring(2, 1);
        //    lbl100.Text = newCarom.Substring(1, 1);
        //    lbl1000.Text = newCarom.Substring(0, 1);
        //    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        //    string fileName = lbl.Text+".png";
        //    string path = Path.Combine(projectDirectory, @"images\", fileName);
        //    Image img = Image.FromFile(path);
        // //   pic_p1_1000.Image = img; // Image.FromFile(path);
        //    PictureBox pic;
        //    pic = Controls.Find("pic_" + playerNumber + "_" + pointsPassed, true).FirstOrDefault() as PictureBox;
        //    pic.Image = img;
        //    pic.Tag = lbl.Text;
        //    //pic_p1_1

        }



        
        private PictureBox ComposeElemName(PictureBox elemPic, string picValue)
        { // Create pictureBox 
            string picName = elemPic.Name;
            string[] picNameSplit = picName.Split('_');
            string pNum = picNameSplit.GetValue(1).ToString();
            string pElem  = "pic_"+pNum+"_"+picValue;


            return Controls.Find(pElem, true).FirstOrDefault() as PictureBox;
        }

        private int GetPassedValue(PictureBox pic)
        {
            string[] picNameSplit = pic.Name.Split('_');
            return int.Parse(picNameSplit.GetValue(2).ToString());
        }

        private void Form1_MouseDownImgClick(object sender, MouseEventArgs e)
        {
                  
            PictureBox pic = sender as PictureBox;
            int passedValue = GetPassedValue(pic);
            PictureBox pic100 = ComposeElemName(pic, "100");
            PictureBox pic10 = ComposeElemName(pic, "10");
            PictureBox pic1 = ComposeElemName(pic, "1");
            
            string p1Carom = pic100.Tag.ToString() + pic10.Tag.ToString() + pic1.Tag.ToString();
            var car = int.Parse(p1Carom);
            if (e.Button == MouseButtons.Left)
            {
                car += passedValue;
                if (car > 999)
                {
                    return;
                }
                GlobalVars.p1Caroms += passedValue;
            }
            if (e.Button == MouseButtons.Right)
            {
                car -= passedValue;
                if (car <= -1)
                {
                    return;
                }
                GlobalVars.p1Caroms -= passedValue;
            }

            
            var newCarom = Functions.GenPadding(car);

            //pic1000.Tag = newCarom.Substring(0, 1);
            pic100.Tag = newCarom.Substring(1, 1);
            pic10.Tag = newCarom.Substring(2, 1);
            pic1.Tag = newCarom.Substring(3, 1);

            pic1.Image = GetPic(pic1.Tag.ToString() + ".png");
            pic10.Image = GetPic(pic10.Tag.ToString() + ".png");
            pic100.Image = GetPic(pic100.Tag.ToString() + ".png");
         //   pic1000.Image = GetPic(pic1000.Tag.ToString() + ".png");
        }


        private static Image GetPic(string imgName)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            //return Image.FromFile(Path.Combine(projectDirectory, @"images\", imgName));
            return Image.FromFile(Path.Combine(GlobalVars.projectDirectory, @"images\", imgName));
            
        }

        private void MouseHideLbl(object sender, EventArgs e)
        {

        }

        private void MouseOverImg(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = System.Drawing.Color.Beige;
            string picName = pic.Name;
            string markerName = picName + "_marker";
            Label lblMark = Controls.Find(markerName, true).FirstOrDefault() as Label;
            lblMark.Visible = true;
        }

        private void MouseOverImgHide(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = System.Drawing.Color.Blue;
            string picName = pic.Name;
            string markerName = picName + "_marker";
            Label lblMark = Controls.Find(markerName, true).FirstOrDefault() as Label;
            lblMark.Visible = false;
        }

        private void ExitApplication(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void genHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = System.Drawing.Color.LightBlue;
            lbl.ForeColor = System.Drawing.Color.Black;

        }

        private void restoreHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = System.Drawing.Color.Blue;
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void setP1Carom(object sender, EventArgs e)
        {
           
        }

        private void InitBoard()
        {


            string familyName = "";
            string familyNameAndStyle;
            FontFamily[] fontFamilies;
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            privateFontCollection.AddFontFile("L:\\GITHUB\\score\\Properties\\digital-7.ttf");
            lbl_p1_car_1.Font = new Font(privateFontCollection.Families[0], 250);
            lbl_p1_car_10.Font = new Font(privateFontCollection.Families[0], 250);
            lbl_p1_car_100.Font = new Font(privateFontCollection.Families[0], 250);
            lbl_p2_car_1.Font = new Font(privateFontCollection.Families[0], 250);
            lbl_p2_car_10.Font = new Font(privateFontCollection.Families[0], 250);
            lbl_p2_car_100.Font = new Font(privateFontCollection.Families[0], 250);

            p1_make_1.Font = new Font(privateFontCollection.Families[0], 180);
            p1_make_10.Font = new Font(privateFontCollection.Families[0], 180);
            p1_make_100.Font = new Font(privateFontCollection.Families[0], 180);
            p2_make_1.Font = new Font(privateFontCollection.Families[0], 180);
            p2_make_10.Font = new Font(privateFontCollection.Families[0], 180);
            p2_make_100.Font = new Font(privateFontCollection.Families[0], 180);

           

            p1Bord.lbl1 = lbl_p1_car_1;
            p1Bord.lbl10 = lbl_p1_car_10;
            p1Bord.lbl100 = lbl_p1_car_100;
            p1Bord.lblMake1 = p1_make_1;
            p1Bord.lblMake10 = p1_make_10;
            p1Bord.lblMake100 = p1_make_100;
            
           
            p2Bord.lbl1 = lbl_p2_car_1;
            p2Bord.lbl10 = lbl_p2_car_10;
            p2Bord.lbl100 = lbl_p2_car_100;
            p2Bord.lblMake1 = p2_make_1;
            p2Bord.lblMake10 = p2_make_10;
            p2Bord.lblMake100 = p2_make_100;

            p1Bord.ResetBoard();
            p2Bord.ResetBoard();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            p1Bord.ResetBoard();
            p2Bord.ResetBoard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void P1Caram(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p1Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
        }

        private void P2Caram(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p2Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
        }

        private void P1Make(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
           p1Bord.SetMake(leftMouse, Convert.ToInt32(lbl.Tag));
        }

        private void P2Make(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p2Bord.SetMake(leftMouse, Convert.ToInt32(lbl.Tag));
        }
    }

   
}
