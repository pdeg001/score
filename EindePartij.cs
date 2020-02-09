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
    }
}
