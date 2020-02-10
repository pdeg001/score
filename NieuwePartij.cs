using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace peter
{
    public partial class NieuwePartij : Form
    {
        Boolean autoInnings = true, addPlayers = false;
        public NieuwePartij()
        {
            InitializeComponent();
        }

        private void NieuwePartij_Load(object sender, EventArgs e)
        {

            //GetImgPath();
            if (autoInnings == true)
            {
                chk_auto_beurten.Image = Functions.GetImgCheckMark();
                autoInnings = true;
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_nee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void btn_ja_Click(object sender, EventArgs e)
        {
            scorebord f1 = (scorebord)Application.OpenForms["scorebord"];
            f1.NewGame();
            Owner.Show();
            Hide();
            
        }

        private void checkBox1_Paint(object sender, PaintEventArgs e)
        {
           // ControlPaint.DrawCheckBox(e.Graphics, 11, 44, 133, 133, ButtonState.Checked | ButtonState.Flat);
        }

        private void SetAutoBeurten()
        {
            if (autoInnings == false)
            {
                chk_auto_beurten.Image = Functions.GetImgCheckMark();
                autoInnings = true;
            }
            else
            {
                chk_auto_beurten.Image = null;
                autoInnings = false;
            }
        }

        private void lbl_buerten_automatisch_MouseUp(object sender, MouseEventArgs e)
        {
            SetAutoBeurten();
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            if (addPlayers == false)
            {
                chkSpelersInvoeren.Image = Functions.GetImgCheckMark();
                addPlayers = true;
                ShowPlayerObjects();
            }
            else
            {
                chkSpelersInvoeren.Image = null;
                addPlayers = false;
                ShowPlayerObjects();
            }

        }


        private void ShowPlayerObjects()
        {
            txtP1Name.Visible = addPlayers;
            txtP1Caroms.Visible = addPlayers;
            btnP1Start.Visible = addPlayers;

            txtP2Name.Visible = addPlayers;
            txtP2Caroms.Visible = addPlayers;
            btnP2Start.Visible = addPlayers;
        }

        private void genHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF"); //System.Drawing.Color.LightBlue;
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void restoreHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#0a00ff");//#FF00FF System.Drawing.Color.Blue;
            lbl.ForeColor = System.Drawing.Color.Yellow;
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

        private void lbl_spelers_invoeren_Click(object sender, EventArgs e)
        {

        }

        private void txtP1Caroms_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        


    }
}
