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
    public partial class FrmPromo : Form
    {
        public FrmPromo()
        {
            InitializeComponent();
            LblText.Text = $"01234567890123456789\nRegel 2\nRegel 3";
        }

        private void FrmPromo_Move(object sender, EventArgs e)
        {
            scorebord f1 = (scorebord)Application.OpenForms["scorebord"];
            f1.EndPromo();
            Hide();
        }
    }
}
