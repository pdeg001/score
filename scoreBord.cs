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
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;
using System.Net.NetworkInformation;


namespace peter
{
    
    public partial class scorebord : Form
    {
     //   [DllImport("user32.dll", EntryPoint = "LoadCursorFromFile")]
     //   public static extern IntPtr LoadCursorFromFile(string filename);

        ClsBord p1Bord = new ClsBord();
        ClsBord p2Bord = new ClsBord();
        ProcesScore P1ProcessScore = new ProcesScore();
        ProcesScore P2ProcessScore = new ProcesScore();
        ClsInnings innings = new ClsInnings();
        GameTime spelDuurTimer = new GameTime();
        Form frmNewGame = new NieuwePartij();
        Form frmEndGame = new EindePartij();
        Form frmPromo = new FrmPromo();

        Boolean startNewGame = false;
        Boolean disableHoverItems = false;
        Boolean inningsSet = true;
        Boolean gameStarted = false;
        bool changeBorder;
        bool hasInternet = false;
        bool p1Play =false, p2Play = false;
        bool firstShow = true;
        bool playerNameSet = false;
        bool statusSetToMake = false;

        int promoX = 35;
        int promoY = 35;

        

        public scorebord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgLogo.Image = Functions.GetImgLogo();
            //  SetCursor();
            //this.Cursor = new Cursor(Application.StartupPath + "\\Cursor(2).cur");
            InitBoard();

         //   Cursor mycursor = new Cursor(Cursor.Current.Handle);
            //Console.WriteLine(Functions.GetMouseCoursorPath());
         //   IntPtr colorcursorhandle = LoadCursorFromFile(Functions.GetMouseCoursorPath());
         //   mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
         //   this.Cursor = mycursor;
            this.Cursor = Cursors.NoMove2D;

            hasInternet =  Functions.CheckForInternetConnection();
            if (hasInternet)
            {
                LblTijd.Text = DateTime.Now.ToString("HH:mm");
                LblDag.Text = DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("dd MMMM yyyy");
            }
            else
            {
                PnlTijd.Visible = false;
                TmrTijd.Enabled = false;
            }
        }


        public static Cursor CreateCursor(Bitmap bm, Size size)
        {

            bm = new Bitmap(bm, size);
            return new Cursor(bm.GetHicon());
        }

        public void SetCursor()
        {
            Bitmap bm = (Bitmap)imageList1.Images[0];
            this.Cursor = CreateCursor(bm, new Size(48, 48));
        }

        private void ExitApplication(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void genHoverMake(object sender, EventArgs e)
        {

        }

        private void restoreHoverMake(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");//#FF00FF System.Drawing.Color.Blue;
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void genHover(object sender, EventArgs e)
        {
            if (firstShow)
                return;

            if (startNewGame)
                return;

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


        private void InitBoard()
        {
         //   Console.WriteLine(Functions.GetIP());
         //   lblIpNumber.Text = Functions.GetIP();

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
            disableHoverItems = true;
           // DisableClickItems(false);
        }

        public void DisableClickItems(Boolean enable)
        {
            lbl_p1_car_1.Enabled = enable;
            
            lbl_p1_car_10.Enabled = enable;
            lbl_p1_car_100.Enabled = enable;
            p1_make_1.Enabled = enable;
            p1_make_10.Enabled = enable;
            p1_make_100.Enabled = enable;

            lbl_p2_car_1.Enabled = enable;
            lbl_p2_car_10.Enabled = enable;
            lbl_p2_car_100.Enabled = enable;
            p2_make_1.Enabled = enable;
            p2_make_10.Enabled = enable;
            p2_make_100.Enabled = enable;

            lbl_p1_name.Enabled = enable;
            lbl_p2_name.Enabled = enable;
            lbl_innings.Enabled = enable;

        }

        private void P1Caram(object sender, MouseEventArgs e)
        {
            if (p2Play || firstShow)
                return;

            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p1Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
            p1Bord.CalcMoyenne();
        }

        private void P2Caram(object sender, MouseEventArgs e)
        {
            if (p1Play || firstShow)
                return;

            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p2Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
            p2Bord.CalcMoyenne();

        }

        private void P1Make(object sender, MouseEventArgs e)
        {
            if (firstShow || playerNameSet)
                return;

            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p1Bord.SetMake(leftMouse, Convert.ToInt32(lbl.Tag));
            p1Bord.CalcMoyenne();
        }

        private void P2Make(object sender, MouseEventArgs e)
        {
            if (firstShow && playerNameSet)
                return;

            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p2Bord.SetMake(leftMouse, Convert.ToInt32(lbl.Tag));
            p2Bord.CalcMoyenne();
        }

        private void SetInning(object sender, MouseEventArgs e)
        {
            if (firstShow)
                return;
            innings.setInnings(e.Button == MouseButtons.Left);
            //  lbl_p1_moyenne1.Text = p1Bord.calcMoyenne(inningsCount);
           // innings.setInnings(true);
            inningsSet = true;
            p1Bord.CalcMoyenne();
            p2Bord.CalcMoyenne();
            
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

        public void ResetCounter()
        {
            p1Bord.ResetBoard();
            p2Bord.ResetBoard();
        }

        public void NewGame(bool players)
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
            firstShow = true;
            if (players == false)
                lbl_p1_name.Text = "SPELER 1"; 
                lbl_p2_name.Text = "SPELER 2"; 
                p1Bord.EnableMakeHover();
                p2Bord.EnableMakeHover();
                playerNameSet = players;
        }


        public void EndGame()
        {
            imgLogo.Image = Functions.GetImgLogo();
            spelDuurTimer.EnableGameTime(false);
            btn_nieuwe_partij.Text = "Nieuwe Partij";
            btn_nieuwe_partij.BackColor = Color.Green;
            startNewGame = false;
            firstShow = true;
            p1Play = true;
            p2Play = true;
            p1Bord.DisableMakeHover();
            p1Bord.DisableCaromHover();
            p2Bord.DisableCaromHover();
            p2Bord.DisableMakeHover();

        }

        public void SetP1Data(string name, string toMake)
        {
            lbl_p1_name.Text    = name;
            p1_make_100.Text    = toMake.Substring(0, 1);
            p1_make_10.Text     = toMake.Substring(1, 1);
            p1_make_1.Text      = toMake.Substring(2, 1);
           
        }

        public void SetP2Data(string name, string toMake)
        {
            lbl_p2_name.Text    = name;
            p2_make_100.Text    = toMake.Substring(0, 1);
            p2_make_10.Text     = toMake.Substring(1, 1);
            p2_make_1.Text      = toMake.Substring(2, 1);
            
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
                gameStarted = true;
                disableHoverItems = false;
                firstShow = false;
                p1Bord.EnableMakeHover();
                p2Bord.EnableMakeHover();
                P1NameClick();
               
            }
        }

        private void Lbl_pName_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            changeBorder = false;
            lbl.Refresh();
            //if (gameStarted)
            //{
            //    lbl.BackColor = Color.White;
            //}
            //else
            //{
            //    lbl.BackColor = Color.Transparent;
            //}
        }

        private void Lbl_pName_MouseEnter(object sender, EventArgs e)
        {
            if (firstShow)
                return;

            Label lbl = sender as Label;
            changeBorder = true;
            lbl.Refresh();

           // lbl.BackColor = Color.Red;
        }

        private void lbl_name_Paint(object sender, PaintEventArgs e)
        {
            int width = 8;

            if (changeBorder)
            {
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                              Color.Red, width, ButtonBorderStyle.Solid, //left
                              Color.Red, width, ButtonBorderStyle.Solid, //top
                              Color.Red, width, ButtonBorderStyle.Solid, //right 
                              Color.Red, width, ButtonBorderStyle.Solid); //bottomwidth
            }
            else
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, this.BackColor, ButtonBorderStyle.None);
        }

        private void p2_make_100_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;
            if (!lbl.Enabled)
                lbl.BackColor = Color.Blue;
                lbl.ForeColor = Color.Yellow;
        }

        private void lbl_p1_name_Click(object sender, EventArgs e)
        {
            if (firstShow)
                return;
            P1NameClick();
        }

        private void lbl_p2_name_Click(object sender, EventArgs e)
        {
            if (firstShow)
                return;
            P2NameClick();
        }

        private void P1NameClick()
        {
            p2Bord.DisableCaromHover();
            p1Bord.EnableCaromHover();
            if (GlobalVars.autoInnings && inningsSet == false)
            {
                innings.setInnings(true);
                inningsSet = true;
            }
            p1Play = true;
            p2Play = false;

            lbl_p1_name.BackColor = Color.White;
            lbl_p1_name.ForeColor = Color.Black;

            lbl_p2_name.BackColor = Color.Transparent;
            lbl_p2_name.ForeColor = Color.White;

            changeBorder = false;
            lbl_p1_name.Refresh();
        }

        private void P2NameClick()
        {
            p1Bord.DisableCaromHover();
            p2Bord.EnableCaromHover();

            inningsSet = false;
            p1Play = false;
            p2Play = true;
            lbl_p1_name.BackColor = Color.Transparent;
            lbl_p1_name.ForeColor = Color.White;

            lbl_p2_name.BackColor = Color.White;
            lbl_p2_name.ForeColor = Color.Black;
            changeBorder = false;
            lbl_p2_name.Refresh();
        }

        private void lbl_game_timer_Click(object sender, EventArgs e)
        {
            imgLogo.Image = Functions.GetImgKraai();
            imgLogo.Refresh();
            WaitTimer(3000);
            imgLogo.Image = Functions.GetImgLogo();
        }

        private void TmrTijd_Tick(object sender, EventArgs e)
        {
            LblTijd.Text = DateTime.Now.ToString("HH:mm");
            LblDag.Text = DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("dd MMMM yyyy");
        }


        public void EndPromo()
        {
            TmrPromo.Enabled = false;
        }
        private void TmrInactive_Tick(object sender, EventArgs e)
        {
            if (TmrPromo.Enabled)
                return;
            TmrPromo.Enabled = true;

        }

        private void TmrPromo_Tick(object sender, EventArgs e)
        {
            if (frmPromo.Visible == false)
            {
                frmPromo.Visible = true;
                frmPromo.Top = 70;
                frmPromo.Left = 70;
            }
            SHowScreenSaver();
        }

        private void SHowScreenSaver()
        {
            //HORIZONTAL
            if (frmPromo.Left == 0 || frmPromo.Right == this.ClientRectangle.Width)
                promoX = -promoX;

            if (promoX > 0)
                frmPromo.Left = Math.Min(frmPromo.Left + promoX, this.ClientRectangle.Width - frmPromo.Width);
            else
                frmPromo.Left = Math.Max(frmPromo.Left + promoX, 0);

            //GET PROMO TOP
            if (frmPromo.Top - 35 <= 0)
                promoY = 35; // -promoY;

            if (frmPromo.Bottom + 35 >= 1050)
                promoY = -Math.Abs(promoY);
//            Console.WriteLine($"BOTTOM {frmPromo.Bottom} promoY = {promoY}");

            frmPromo.Top += promoY;
        }

        private void scorebord_MouseMove(object sender, MouseEventArgs e)
        {
            if (TmrPromo.Enabled)
            {
                TmrPromo.Enabled = false;
                frmPromo.Hide();

            }

        }

        

        public void WaitTimer(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }

    


}
