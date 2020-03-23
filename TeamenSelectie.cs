using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace peter
{
    using TSP = TeamSelectionPlayers;
    public partial class TeamenSelectie : Form
    {
        //Label p1Clicked = new Label();
        //Label p2Clicked = new Label();
        //Label p1Make = new Label();
        //Label p2Make = new Label();

        Image img = Functions.GetImgStartFlag();

        //    TeamSelection clsTeamSelectHome = new TeamSelection();
        //    TeamSelection clsTeamSelectVisit = new TeamSelection();
        TeamSelectionPlayers TSP = new TeamSelectionPlayers();
        
        string p1PlayerName = "";
        string p1PlayerMake = "";
        string p2PlayerName = "";
        string p2PlayerMake = "";
        string playerStartsGame = "null";



        scorebord f1 = (scorebord)Application.OpenForms["scorebord"];


        public TeamenSelectie()
        {
            InitializeComponent();
        //    SetTeamSelectionClassLabels();
        }

        private void TeamenSelectie_Load(object sender, EventArgs e)
        {

        }

        //private void SetTeamSelectionClassLabels()
        //{
        //    TeamSelectionPlayers.PStart = "test";
        //    //Home
        //    clsTeamSelectHome.p1Name = P1NameHome;
        //    clsTeamSelectHome.p2Name = P2NameHome;
        //    clsTeamSelectHome.p3Name = P3NameHome;
        //    clsTeamSelectHome.p4Name = P4NameHome;
        //    clsTeamSelectHome.p1Make = P1MakeHome;
        //    clsTeamSelectHome.p2Make = P2MakeHome;
        //    clsTeamSelectHome.p3Make = P3MakeHome;
        //    clsTeamSelectHome.p4Make = P4MakeHome;
        //    clsTeamSelectHome.playerName = TeamSelectionPlayers.P1;
        //    clsTeamSelectHome.playerMake = TeamSelectionPlayers.P1Make;
        //    //clsTeamSelectHome.playerStarts = TeamSelectionPlayers.PStart;
        //    //Visitors
        //    clsTeamSelectVisit.p1Name = P1NameVisit;
        //    clsTeamSelectVisit.p2Name = P2NameVisit;
        //    clsTeamSelectVisit.p3Name = P3NameVisit;
        //    clsTeamSelectVisit.p4Name = P4NameVisit;
        //    clsTeamSelectVisit.p1Make = P1MakeVisit;
        //    clsTeamSelectVisit.p2Make = P2MakeVisit;
        //    clsTeamSelectVisit.p3Make = P3MakeVisit;
        //    clsTeamSelectVisit.p4Make = P4MakeVisit;
        //    clsTeamSelectVisit.playerName = TeamSelectionPlayers.P2;
        //    clsTeamSelectVisit.playerMake = TeamSelectionPlayers.P2Make;
        //   // clsTeamSelectVisit.playerStarts = TeamSelectionPlayers.PStart;
        //    clsTeamSelectHome.EnablePlayerHover();
        //    clsTeamSelectVisit.EnablePlayerHover();
        //}


        private void GenHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl.Name == TSP.P1 || lbl.Name == TSP.P2)
                return;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF");
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void RestoreHover(object sender, EventArgs e)
        {

            Label lbl = sender as Label;

            if (lbl.Name == TSP.P1 || lbl.Name == TSP.P2)
                return;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lbl.ForeColor = System.Drawing.Color.Yellow;


        }

        private void GenHoverPlayerMake(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            if (lbl.Name != TSP.P1Make && lbl.Name != TSP.P2Make)
                return;

            lbl.BackColor = Color.Red;
            lbl.ForeColor = Color.White;
        }

        private void RestoreHoverPlayerMake(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            if (lbl.Name != TSP.P1Make && lbl.Name != TSP.P2Make)
                return;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000AFF");
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }


        private void btn_continue_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }


        private void RestoreLabelColorHome()
        {
            P1NameHome.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P2NameHome.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P3NameHome.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P4NameHome.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
        }

        private void PlayerMake_MouseUp(object sender, MouseEventArgs e)
        {
            Label pMake = sender as Label;

        }

        private void RestoreLabelColorVisitor()
        {
            P1NameVisit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P2NameVisit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P3NameVisit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P4NameVisit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
        }

        private void PlayerClicked(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl.Name.IndexOf("Home") > -1)
            {
                RestoreLabelColorHome();
                if (lbl.Name != TSP.P1 || TSP.P1 == "")//p1Clicked.Name)
                {
                    lbl.BackColor = Color.Green;
                    TSP.P1 = lbl.Name;
                    TSP.P1Make = lbl.Tag.ToString();
                }
                else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    TSP.P1 = "";
                    TSP.P1Make = "";
                }
            }

            if (lbl.Name.IndexOf("Visit") > -1)
            {
                RestoreLabelColorVisitor();
                if (lbl.Name != TSP.P2 || TSP.P2 == "")
                {
                    lbl.BackColor = Color.Green;
                    TSP.P2 = lbl.Name;
                    TSP.P2Make = lbl.Tag.ToString();
                }
                else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    TSP.P2 = "";
                    TSP.P2Make = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string GetPlayerMake(string lblMake)
        {
            Label lblMakeCarom = Controls.Find(lblMake, true).FirstOrDefault() as Label;

            return lblMakeCarom.Text;
        }

        private void BtnGenHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
        }

        private void PlayerStart(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;

            Console.WriteLine($"PLAYER START : {TSP.PStart}");
            if(TSP.PStart == null)
            {
                TSP.PStart = lbl.Name;

                return;
            }

        }
    }
}




