using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace peter
{
    public partial class TeamenSelectie : Form
    {

        Label p1Clicked = new Label();
        Label p2Clicked = new Label();
        Label p1Make = new Label();
        Label p2Make = new Label();

        Image img = Functions.GetImgStartFlag();

        TeamSelection clsTeamSelectHome = new TeamSelection();
        TeamSelection clsTeamSelectVisit = new TeamSelection();

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

            if (lbl.Name == p1Clicked.Name || lbl.Name == p2Clicked.Name)
                return;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF");
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void RestoreHover(object sender, EventArgs e)
        {

            Label lbl = sender as Label;

            if (lbl.Name == p1Clicked.Name || lbl.Name == p2Clicked.Name)
                return;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lbl.ForeColor = System.Drawing.Color.Yellow;


        }

        private void GenHoverPlayerMake(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            if ((lbl.Name.IndexOf("p1") != -1) && p1PlayerName == "")
            {
                Console.WriteLine("PPPPP");
                return;
            }

            lbl.BackColor = Color.Red;
            lbl.ForeColor = Color.White;
        }

        private void RestoreHoverPlayerMake(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            lbl.BackColor = Color.Blue;
            lbl.ForeColor = Color.Yellow;
        }


        private void btn_continue_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }


        private void RestoreLabelColorHome()
        {
            P1NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P2NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P3NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P4NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
        }

        private void PlayerMake_MouseUp(object sender, MouseEventArgs e)
        {
            Label pMake = sender as Label;

        }

        private void RestoreLabelColorUit()
        {
            P1NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P2NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P3NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            P4NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
        }

        private void PlayerClicked(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl.Name.IndexOf("Local") > -1)
            {
                RestoreLabelColorHome();
                if (lbl.Name != p1Clicked.Name)
                {
                    lbl.BackColor = Color.Green;
                    p1Clicked.Name = lbl.Name;
                    p1PlayerMake = GetPlayerMake(lbl.Tag.ToString());
                    p1Make = Controls.Find(lbl.Tag.ToString(), true).FirstOrDefault() as Label;
                }
                else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    p1Clicked.Name = "name";
                    p1PlayerName = "";
                    p1Make = new Label();
                }
            }

            if (lbl.Name.IndexOf("Uit") > -1)
            {
                RestoreLabelColorUit();
                if (lbl.Name != p2Clicked.Name)
                {
                    lbl.BackColor = Color.Green;
                    p2Clicked.Name = lbl.Name;
                    p2PlayerMake = GetPlayerMake(lbl.Tag.ToString());
                    p2Make = Controls.Find(lbl.Tag.ToString(), true).FirstOrDefault() as Label;
                }
                else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    p2Clicked.Name = "name";
                    p2PlayerName = "";
                    p2Make = new Label();
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
    }
}
