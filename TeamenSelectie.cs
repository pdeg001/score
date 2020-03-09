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
        Color p1HomeColor;
        Color p2HomeColor;
        Color p3HomeColor;
        Color p4HomeColor;
        Color p1VisitColor;
        Color p2VisitColor;
        Color p3VisitColor;
        Color p4VisitColor;

        Label p1Clicked = new Label();
        Label p2Clicked = new Label();

        

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

            Console.WriteLine($"LABELNAME : {lbl.Name}  P1CLICKED.NAME : {p1Clicked.Name}");
            Console.WriteLine($"LABELNAME : {lbl.Name}  P2CLICKED.NAME : {p2Clicked.Name}");
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
                    GetPlayerMake(lbl.Tag.ToString());
                } else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    p1Clicked.Name = "name";
                }
            }

            if (lbl.Name.IndexOf("Uit") > -1)
            {
                RestoreLabelColorUit();
                if (lbl.Name != p2Clicked.Name)
                {
                    lbl.BackColor = Color.Green;
                    p2Clicked.Name = lbl.Name;
                } else
                {
                    lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                    p2Clicked.Name = "name";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetPlayerMake(string lblMake)
        {
           Label lblx = new Label();
            var lbl = Controls.Find(lblMake, true);
            //  var label = new Label[] lblMake;
            lblx = lbl;
            Console.WriteLine($"PLAYER MAKE = {lbl}");
        }
    }
}
