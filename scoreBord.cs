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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Security.Permissions;
using System.Dynamic;

namespace peter
{
    
    public partial class scorebord : Form
    {
          // [DllImport("user32.dll", EntryPoint = "LoadCursorFromFile")]
          // public static extern IntPtr LoadCursorFromFile(string filename);

        ShowPromo ClsSHowPromo = new ShowPromo();
        Panel pnPromo;

        ClsBord p1Bord = new ClsBord();
        ClsBord p2Bord = new ClsBord();
       
       
        ClsInnings innings = new ClsInnings();
        StoreCurrentScore scs = new StoreCurrentScore();
        GameTime spelDuurTimer = new GameTime();
        Form frmNewGame = new NieuwePartij();
        Form frmEndGame = new EindePartij();


        Boolean startNewGame = false;
        Boolean disableHoverItems = false;
        Boolean inningsSet = true;
        Boolean gameStarted = false;
        bool changeBorder;
        bool hasInternet = false;
        bool p1Play =false, p2Play = false;
        bool firstShow = true;
        bool playerNameSet = false;

        Color newGameButtonColor;

        int promoX = 35;
        int promoY = 35;

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]

        

        public scorebord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        Functions.CheckOsLinux();
            fileSystemWatcher.Path = Functions.GetAppPath();
            imgLogo.Image = Functions.GetImgLogo();

            InitBoard();
            
            Cursor = Cursors.NoMove2D;
           

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

        private void genHover(object sender, EventArgs e)
        {
            if (firstShow)
                return;

            if (startNewGame)
                return;

            if (sender.GetType().Name == "Label")
            {
                Label lbl = sender as Label;
                lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF"); //System.Drawing.Color.LightBlue;
                lbl.ForeColor = System.Drawing.Color.Yellow;
            }

            if(sender.GetType().Name == "Panel")
            {
                Panel pnl = sender as Panel;
                pnl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF"); //System.Drawing.Color.LightBlue;
            }
        }

        private void restoreHover(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "Label")
            {
                Label lbl = sender as Label;
                lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");//#FF00FF System.Drawing.Color.Blue;
                lbl.ForeColor = System.Drawing.Color.Yellow;
            }

            if(sender.GetType().Name == "Panel")
            {
                Panel pnl = sender as Panel;
                pnl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");//#FF00FF System.Drawing.Color.Blue;
            }
        }


        private void InitBoard()
        {
            spelDuurTimer.lblSpelDuur = lbl_game_timer;
            spelDuurTimer.GameTimer();
            
            innings.lblInnings = lbl_innings;
            innings.lblInning1 = lbl_inning_1;
            innings.lblInning10 = lbl_inning_10;
            innings.lblInning100 = lbl_inning_100;
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
            if (File.Exists("currGame.pdg"))
                RestoreGame();
        }

        private void P1Caram(object sender, MouseEventArgs e)
        {
            if (p2Play || firstShow)
                return;

            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p1Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
            p1Bord.CalcMoyenne();
            TmrInactive.Enabled = false;
            TmrInactive.Enabled = true;

            WriteCurrScore();
            Thread.Sleep(100);
        }

        private void P2Caram(object sender, MouseEventArgs e)
        {
            if (p1Play || firstShow)
                return;

            Label lbl = sender as Label;
            Boolean leftMouse = e.Button == MouseButtons.Left;
            p2Bord.SetCaramBoles(leftMouse, Convert.ToInt32(lbl.Tag));
            p2Bord.CalcMoyenne();

            WriteCurrScore();
            Thread.Sleep(100);
        }

        private void P1Make(object sender, MouseEventArgs e)
        {
            if (startNewGame == false)
                return;

            Label lbl = sender as Label;
            //if (lbl.Text == "0")
            //    return;

            Boolean leftMouse = e.Button == MouseButtons.Left;
            p1Bord.SetMake(leftMouse, Convert.ToInt32(lbl.Tag));
            p1Bord.CalcMoyenne();
        }

        private void P2Make(object sender, MouseEventArgs e)
        {
            if (startNewGame == false)
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
            } else
            {
                frmEndGame.StartPosition = FormStartPosition.Manual;
                frmEndGame.Location = Location;
                frmEndGame.Show(this);
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
            gameStarted = false;
            firstShow = true;
            p1Play = true;
            p2Play = true;
            p1Bord.DisableMakeHover();
            p1Bord.DisableCaromHover();
            p2Bord.DisableCaromHover();
            p2Bord.DisableMakeHover();

            //DELETE CURRGAME.PDEG
            if (File.Exists("currGame.pdg"))
                File.Delete("currGame.pdg");

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
                InitNewGame();
            }
        }

        private void InitNewGame()
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

        private void Lbl_pName_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            changeBorder = false;
            lbl.Refresh();
        }

        private void Lbl_pName_MouseEnter(object sender, EventArgs e)
        {
            if (firstShow)
                return;

            Label lbl = sender as Label;
            changeBorder = true;
            lbl.Refresh();
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
            p2Ball.Visible = false;
            p1Ball.Visible = true;
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
            WriteCurrScore();
        }

        private void P2NameClick()
        {
            p1Bord.DisableCaromHover();
            p2Bord.EnableCaromHover();
            p2Ball.Visible = true;
            p1Ball.Visible = false;


            inningsSet = false;
            p1Play = false;
            p2Play = true;
            lbl_p1_name.BackColor = Color.Transparent;
            lbl_p1_name.ForeColor = Color.White;

            lbl_p2_name.BackColor = Color.White;
            lbl_p2_name.ForeColor = Color.Black;
            changeBorder = false;
            lbl_p2_name.Refresh();
            WriteCurrScore();
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
           if(gameStarted)
            WriteCurrScore();
        }


        public void EndPromo()
        {
            TmrPromo.Enabled = false;
        }
        private void TmrInactive_Tick(object sender, EventArgs e)
        {
            

            TmrInactive.Enabled = false;
            if (TmrPromo.Enabled)
            {
                return;
            } else
            {
                Cursor.Position = new Point(this.ClientRectangle.Right, this.ClientRectangle.Bottom);
            }

            TmrPromo.Enabled = true;
        }

        private void TmrPromo_Tick(object sender, EventArgs e)
        {
            if (!Controls.Contains(pnPromo))
            {
                
                CreatePromoPanel();
            }
            ShowPromo.ShowScreenSaver(pnPromo);
        }

        private void CreatePromoPanel()
        {
            pnPromo = ShowPromo.CreatePromoPanel();
            this.Controls.Add(pnPromo);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            pnPromo.BringToFront();
        }

        public bool CheckPromoActive()
        {
            if (!Controls.Contains(pnPromo))
                return false;

            return true;
        }

        public void DisablePromo()
        {
            TmrPromo.Enabled = false;
            if (Controls.Contains(pnPromo))
                Controls.Remove(pnPromo);

            TmrInactive.Enabled = true;
        }

        public void WaitTimer(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            ShowPromo.SetConfigVars();
        }
        
        private void WriteCurrScore()
        {
            string p1Make = $"{p1_make_100.Text}{p1_make_10.Text}{p1_make_1.Text}";
            string p2Make = $"{p2_make_100.Text}{p2_make_10.Text}{p2_make_1.Text}";
            string p1Score = $"{lbl_p1_car_100.Text}{lbl_p1_car_10.Text}{lbl_p1_car_1.Text}";
            string p2Score = $"{lbl_p2_car_100.Text}{lbl_p2_car_10.Text}{lbl_p2_car_1.Text}";
            string innings = $"{lbl_innings.Text}";
            string duration = $"{lbl_game_timer.Text}";

            string playing;
            if (p1Play == true)
            {
                playing = "p1";
            }
            else
            {
                playing = "p2";
            }
            dynamic flex = new ExpandoObject();

            flex.p1Name = lbl_p1_name.Text;
            flex.p2Name = lbl_p2_name.Text;
            flex.p1Score = p1Score;
            flex.p2Score = p2Score;
            flex.p1Make = p1Make;
            flex.p2Make = p2Make;
            flex.innings = innings;
            flex.duration = duration;
            flex.playing = playing;

            var ser = JsonConvert.SerializeObject(flex);

            ///<summary>Write current score and vars to currGame file</summary>
            ///
            File.WriteAllText("currGame.pdg", ser);
        }

        private void lbl_inning_100_MouseEnter(object sender, EventArgs e)
        {
            pnl_Inning.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF");
        }

        private void lbl_inning_100_MouseLeave(object sender, EventArgs e)
        {
            pnl_Inning.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
        }

        private void btn_nieuwe_partij_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            newGameButtonColor = btn.BackColor;
            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF");
            btn.ForeColor = Color.Yellow;
        }

        private void btn_nieuwe_partij_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = newGameButtonColor;
            btn.ForeColor = Color.White;
        }

        private void RestoreGame()
        {
            string json;
            FileStream cnfReader = new FileStream("currGame.pdg", FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(cnfReader))
            {
                json = sr.ReadToEnd(); 
            }
            cnfReader.Close();

            var gameLines = Game.RestoreCurrGame.FromJson(json);

            lbl_p2_name.Text = gameLines.P2Name;
            lbl_p1_name.Text = gameLines.P1Name;
            lbl_game_timer.Text = gameLines.Duration;
            lbl_innings.Text = gameLines.Innings;
            lbl_inning_100.Text = gameLines.Innings.Substring(0, 1);
            lbl_inning_10.Text = gameLines.Innings.Substring(1, 1);
            lbl_inning_1.Text = gameLines.Innings.Substring(2, 1);

            innings.RestoreInnings(gameLines.Innings);
           
            string[] p1Game = {gameLines.P1Make, gameLines.P1Score, gameLines.P1Name};
            string[] p2Game = {gameLines.P2Make, gameLines.P2Score, gameLines.P2Name};

            p1Bord.RestoreGame(p1Game);
            p2Bord.RestoreGame(p2Game);

            InitNewGame();

            if (gameLines.Playing == "p1")
                P1NameClick();
            else
                P2NameClick();

            string[] time = gameLines.Duration.Split(':');
            spelDuurTimer.mHour = Int32.Parse(time[0]);
            spelDuurTimer.mMinute = Int32.Parse(time[1]);
        }



    }
    //END CLASS
}
