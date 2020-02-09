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
    public partial class NieuwePartij : Form
    {
        public NieuwePartij()
        {
            InitializeComponent();
        }

        private void NieuwePartij_Load(object sender, EventArgs e)
        {
           
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nee_Click(object sender, EventArgs e)
        {
            this.Hide();
           // Owner.Show();
        }

        private void btn_ja_Click(object sender, EventArgs e)
        {
            //scorebord frmMain = new scorebord();
            scorebord f1 = (scorebord)Application.OpenForms["scorebord"];
            f1.ResetGame();
            
            Owner.Show();
            Hide();
            
        }

        private void checkBox1_Paint(object sender, PaintEventArgs e)
        {
           // ControlPaint.DrawCheckBox(e.Graphics, 11, 44, 133, 133, ButtonState.Checked | ButtonState.Flat);
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            chkSpelersInvoeren.Image = Image.FromFile(@"L:\GITHUB\score\images\check.jpg");
//L:\GITHUB\score\images\check.jpg
        }
    }
}
