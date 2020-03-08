using System;
using System.Windows.Forms;

namespace peter
{
    public partial class EindePartij : Form
    {
        public EindePartij()
        {
            InitializeComponent();
        }

        private void btn_ja_Click(object sender, EventArgs e)
        {
            scorebord f1 = (scorebord)Application.OpenForms["scorebord"];
            f1.EndGame();
            Hide();
        }

        private void btn_nee_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void genHoverButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF"); //System.Drawing.Color.LightBlue;
            btn.ForeColor = System.Drawing.Color.Yellow;
        }

        private void restoreHoverButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");//#FF00FF System.Drawing.Color.Blue;
            btn.ForeColor = System.Drawing.Color.Black;
        }
    }
}
