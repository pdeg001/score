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
    
    public partial class scorebord : Form
    {
        ClsBord p1Bord = new ClsBord();
        ClsBord p2Bord = new ClsBord();
        ProcesScore P1ProcessScore = new ProcesScore();
        ProcesScore P2ProcessScore = new ProcesScore();
        ClsInnings innings = new ClsInnings();
        GameTime spelDuurTimer = new GameTime();
        Form frmNewGame = new NieuwePartij();
        Form frmEndGame = new EindePartij();

        Boolean startNewGame = false;

        public Boolean autoInnings = false;
        

        public scorebord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgLogo.Image = Functions.GetImgLogo();
            // System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            //  Cursor.Current = new Cursor(@"images\mouse.cur");
            // this.Cursor = new Cursor(Application.StartupPath + "\\mouse.cur");
            // this.Cursor = new Cursor(@"\mouse.cur");
            SetCursor();
            InitBoard();
        }


        public static Cursor CreateCursor(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
           return new Cursor(bm.GetHicon());
        }

        public void SetCursor()
        {
            Bitmap bm = (Bitmap)imageList1.Images[0];
           // bm.SetResolution(100, 100);
           // bm.
           // this.Cursor = CreateCursor((Bitmap)imageList1.Images[0], new Size(100, 100));
            this.Cursor = CreateCursor(bm, new Size(48, 48));
        }
        private void ExitApplication(object sender, MouseEventArgs e)
        {
            Application.Exit();
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

        private void setP1Carom(object sender, EventArgs e)
        {
           
        }

        private void InitBoard()
        {
            

            spelDuurTimer.lblSpelDuur = lbl_game_timer;
            spelDuurTimer.GameTimer();
            innings.lblInnings = lbl_innings;
            innings.ResetInning();

            p1Bord.lbl1 = lbl_p1_car_1;
            p1Bord.lbl10 = lbl_p1_car_10;
            p1Bord.lbl100 = lbl_p1_car_100;
            p1Bord.lblMake1 = p1_make_1;
            p1Bord.lblMake10 = p1_make_10;
            p1Bord.lblMake100 = p1_make_100;
            p1Bord.lblMoyenne = lbl_p1_moyenne;
            p1Bord.lblPercentage = lbl_p1_prec;
            p1Bord.progressBar = p1_progress;


            p2Bord.lbl1 = lbl_p2_car_1;
            p2Bord.lbl10 = lbl_p2_car_10;
            p2Bord.lbl100 = lbl_p2_car_100;
            p2Bord.lblMake1 = p2_make_1;
            p2Bord.lblMake10 = p2_make_10;
            p2Bord.lblMake100 = p2_make_100;
            p2Bord.lblMoyenne = lbl_p2_moyenne;
            p2Bord.lblPercentage = lbl_p2_perc;
            p2Bord.progressBar = p2_progress;
            p1Bord.ResetBoard();
            p2Bord.ResetBoard();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            p1Bord.ResetBoard();
            p2Bord.ResetBoard();
        }

        private void P1Caram(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p1Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
            p1Bord.CalcMoyenne();
        }

        private void P2Caram(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p2Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
            p2Bord.CalcMoyenne();

        }

        private void P1Make(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p1Bord.SetMake(leftMouse, Convert.ToInt32(lbl.Tag));
            p1Bord.CalcMoyenne();
        }

        private void P2Make(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p2Bord.SetMake(leftMouse, Convert.ToInt32(lbl.Tag));
            p2Bord.CalcMoyenne();
        }

        private void SetInning(object sender, MouseEventArgs e)
        {
            innings.setInnings(e.Button == MouseButtons.Left);
            //  lbl_p1_moyenne1.Text = p1Bord.calcMoyenne(inningsCount);
            p1Bord.CalcMoyenne();
            p2Bord.CalcMoyenne();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_nieuwe_partij_Click(object sender, EventArgs e)
        {
            if (btn_nieuwe_partij.Text == "Nieuwe Partij")
            {
                frmNewGame.StartPosition = FormStartPosition.Manual;
                frmNewGame.Location = Location;
                frmNewGame.Show(this);

                //p1Bord.ResetBoard();
                //p2Bord.ResetBoard();
                //innings.ResetInning();
                //spelDuurTimer.EnableGameTime(true);
                //btn_nieuwe_partij.Text = "Partij Beëindigen";
                //btn_nieuwe_partij.BackColor = Color.Red;
            } else
            {
                frmEndGame.StartPosition = FormStartPosition.Manual;
                frmEndGame.Location = Location;
                frmEndGame.Show(this);
                //btn_nieuwe_partij.Text = "Nieuwe Partij";
                //btn_nieuwe_partij.BackColor = Color.Green;
                //spelDuurTimer.EnableGameTime(false);
            }
        }

       public void NewGame()
        {
            spelDuurTimer.EnableGameTime(false);
            p1Bord.ResetBoard();
            p2Bord.ResetBoard();
            innings.ResetInning();
            btn_nieuwe_partij.Text = "Nieuwe Partij";
            btn_nieuwe_partij.BackColor = Color.Green;
            lbl_game_timer.Text = "00:00";
            imgLogo.Image = Functions.GetImgStartPartij();
            startNewGame = true;
        }

        public void EndGame()
        {
            imgLogo.Image = Functions.GetImgLogo();
            spelDuurTimer.EnableGameTime(false);
            btn_nieuwe_partij.Text = "Nieuwe Partij";
            btn_nieuwe_partij.BackColor = Color.Green;
            spelDuurTimer.EnableGameTime(false);
            p1Bord.ResetBoard();
            p2Bord.ResetBoard();
            innings.ResetInning();
            startNewGame = false;
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
           if (startNewGame == true)
            {
                imgLogo.Image = Functions.GetImgLogo();
                startNewGame = false;
                spelDuurTimer.EnableGameTime(true);
                btn_nieuwe_partij.Text = "Partij Beëindigen";
                btn_nieuwe_partij.BackColor = Color.Red;
            }
        }
    }
   
}
