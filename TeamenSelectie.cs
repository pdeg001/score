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
    public partial class TeamenSelectie : Form
    {
        
        Label p1Clicked = new Label();
        Label p2Clicked = new Label();
        Label p1Make = new Label();
        Label p2Make = new Label();

        Image img = Functions.GetImgStartFlag();

        string p1PlayerName, p1PlayerMake;
        string p2PlayerName, p2PlayerMake;
        string playerStartsGame = "";



        scorebord f1 = (scorebord)Application.OpenForms["scorebord"];

        public TeamenSelectie()
        {
            InitializeComponent();
            p1Clicked.Name = "";
            p2Clicked.Name = "";
           

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
            if(lbl.Name.IndexOf("Home") > -1)
            {
                if (lbl.Name != p1Make.Name)
                    return;
            }

            if (lbl.Name.IndexOf("Visit") > -1)
            {
                if (lbl.Name != p2Make.Name)
                    return;
            }

            lbl.BackColor = Color.Red;
            lbl.ForeColor = Color.White;
            lbl.Image = img;
        }

        private void RestoreHoverPlayerMake(object sender, EventArgs e)
        {
            Label lbl = sender as Label;

            lbl.BackColor = Color.Blue;
            lbl.ForeColor = Color.Yellow;
            lbl.Image = null;
        }


        private void btn_continue_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }


        private void RestoreLabelColorHome()
        {
            lblP1NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP2NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP3NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP4NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
        }

        private void PlayerMake_MouseUp(object sender, MouseEventArgs e)
        {
            Label pMake = sender as Label;

        }

        private void RestoreLabelColorUit()
        {
            lblP1NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP2NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP3NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP4NameUit.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
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
                } else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    p1Clicked.Name = "name";
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
                } else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    p2Clicked.Name = "name";
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
