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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace peter
{
    public partial class FrmPromo : Form
    {
        public FrmPromo()
        {
           Promo promo = new Promo();
            InitializeComponent();
            LblText.Cursor = Cursors.No;
            ImgHeader.Cursor = Cursors.No;

            promo.promoText = LblText;
          //  GetPromoText();
        }

        private void FrmPromo_Move(object sender, EventArgs e)
        {
            scorebord f1 = (scorebord)Application.OpenForms["scorebord"];
            f1.EndPromo();
            Hide();
        }

        public void SetPromoText(string txt)
        {
            LblText.Text = txt;
        }

        public void GetPromoText()
        {
           // string json = File.ReadAllText(@"/home/pi/score/cnf.44");
            string json = File.ReadAllText(Functions.GetConfigFile());
            Console.WriteLine("PROMO");
            string json1 = json.Replace("\"", "\'");

            var welcome = QuickType.Welcome.FromJson(json1);

            LblText.Text = $"{welcome.Message.Line1}\n{ welcome.Message.Line2}\n{welcome.Message.Line3}\n{welcome.Message.Line4}\n{welcome.Message.Line5}";
            LblText.Refresh();

        }
    }
}
