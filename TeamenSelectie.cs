using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace peter
{
    using TSP = TeamSelectionPlayers;
    public partial class TeamenSelectie : Form
    {
        Image img = Functions.GetImgStartFlag();

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
        }

        private void TeamenSelectie_Load(object sender, EventArgs e)
        {

        }

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

            if (lbl.Name == TSP.P1Make || lbl.Name == TSP.P2Make)
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
                    TSP.P1Carom = GetPlayerMake(lbl.Tag.ToString());
                }
                else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    TSP.P1 = "";
                    TSP.P1Make = "";
                    TSP.P1Carom = "";
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
                    TSP.P2Carom = GetPlayerMake(lbl.Tag.ToString());
                }
                else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    TSP.P2 = "";
                    TSP.P2Make = "";
                    TSP.P2Carom = "";
                }
            }
            TmpShowPlayer();
        }

        private void TmpShowPlayer()
        {
            lblp1name.Text = TSP.P1;
            lblp1make.Text = TSP.P1Carom;

            lblp2name.Text = TSP.P2;
            lblp2make.Text = TSP.P2Carom;

            lblpstart.Text = TSP.PStart;
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
            Console.WriteLine("PLAYERSTART");
            Label lbl = sender as Label;
            TSP.PStart = lbl.Name;
            Label lblPname = GetLabelByName(lbl.Tag.ToString());

            //PLAYER START WAS ALREADY SELECTED, UNSELECT AND RETURN
            RestoreMakeLabels();
            //if(TSP.PStart == lbl.Name && TSP.PStart != "")
            //{
            //    TSP.PStart = "";
            //    ImgPlayerStarts.Visible = false;
            //    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000AFF");
            //    lbl.ForeColor = System.Drawing.Color.Yellow;
            //    return;
            //}

            if (lblPname.Name.IndexOf("Home") != -1)
            {
                ImgPlayerStarts.Location = new Point(lblPname.Right-ImgPlayerStarts.Width, lblPname.Top);
            }
            else
            {
                ImgPlayerStarts.Location = new Point(lblPname.Left, lblPname.Top);

            }
            ImgPlayerStarts.BackColor = lblPname.BackColor;
            ImgPlayerStarts.Visible = true;
            TmpShowPlayer();
        }

        private void RestoreMakeLabels()
        {
            TSP.RestoreLabelColorMake(P1MakeHome);
            TSP.RestoreLabelColorMake(P2MakeHome);
            TSP.RestoreLabelColorMake(P3MakeHome);
            TSP.RestoreLabelColorMake(P4MakeHome);
            TSP.RestoreLabelColorMake(P1MakeVisit);
            TSP.RestoreLabelColorMake(P2MakeVisit);
            TSP.RestoreLabelColorMake(P3MakeVisit);
            TSP.RestoreLabelColorMake(P4MakeVisit);
        }

        private Label GetLabelByName(string name)
        {
            return Controls.Find(name, true).FirstOrDefault() as Label;
        }
    }
}




