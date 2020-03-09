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

            if (sender.GetType().Name == "Label")
            {
                Label lbl = sender as Label;
                lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF"); 
                lbl.ForeColor = System.Drawing.Color.Yellow;
            }
                        
        }

        private void RestoreHover(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "Label")
            {
                Label lbl = sender as Label;
                lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                lbl.ForeColor = System.Drawing.Color.Yellow;
            }

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void Player_MouseUp(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            string lblTag = lbl.Tag.ToString();

            if(lblTag.IndexOf("Home") != -1)
            {
                lbl.BackColor = Color.Green;
            }

            if (lblTag.IndexOf("Visit") != -1)
            {

            }

        }

        private void RestoreLabelColorHome()
        {
            lblP1NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP2NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP3NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lblP4NameLocal.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");

        }
    }
}
