using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Linq;

namespace peter
{
    internal class TeamSelection
    {
       static string playerStart;
        public Label p1Name;
        public Label p2Name;
        public Label p3Name;
        public Label p4Name;

        public Label p1Make;
        public Label p2Make;
        public Label p3Make;
        public Label p4Make;

        Label pNameClicked = new Label();
        Label pMake = new Label();

        
       
        TeamenSelectie f1 = (TeamenSelectie)Application.OpenForms["teamenselectie"];


        public void Swap(ref string playerStarts)
        {
         playerStart = playerStarts;
          
        }

        public void EnablePlayerHover()
        {
            p1Name.MouseEnter += new EventHandler(GenHover);
            p1Name.MouseLeave += new EventHandler(RestoreHover);
            p2Name.MouseEnter += new EventHandler(GenHover);
            p2Name.MouseLeave += new EventHandler(RestoreHover);
            p3Name.MouseEnter += new EventHandler(GenHover);
            p3Name.MouseLeave += new EventHandler(RestoreHover);
            p4Name.MouseEnter += new EventHandler(GenHover);
            p4Name.MouseLeave += new EventHandler(RestoreHover);

            p1Make.MouseEnter += new EventHandler(GenHoverMake);
            p1Make.MouseLeave += new EventHandler(RestoreHoverMake);
            p2Make.MouseEnter += new EventHandler(GenHoverMake);
            p2Make.MouseLeave += new EventHandler(RestoreHoverMake);
            p3Make.MouseEnter += new EventHandler(GenHoverMake);
            p3Make.MouseLeave += new EventHandler(RestoreHoverMake);
            p4Make.MouseEnter += new EventHandler(GenHoverMake);
            p4Make.MouseLeave += new EventHandler(RestoreHoverMake);

            p1Name.MouseUp += new MouseEventHandler(PlayerClicked);
            p2Name.MouseUp += new MouseEventHandler(PlayerClicked);
            p3Name.MouseUp += new MouseEventHandler(PlayerClicked);
            p4Name.MouseUp += new MouseEventHandler(PlayerClicked);

            p1Make.MouseUp += new MouseEventHandler(PlayerStartClick);
            p2Make.MouseUp += new MouseEventHandler(PlayerStartClick);
            p3Make.MouseUp += new MouseEventHandler(PlayerStartClick);
            p4Make.MouseUp += new MouseEventHandler(PlayerStartClick);

            pNameClicked.Name = "name";
        }

        private void GenHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (pNameClicked.Name == lbl.Name)
                return;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF00FF");
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void RestoreHover(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (pNameClicked.Name == lbl.Name)
                return;

            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }

        private void GenHoverMake(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            Console.WriteLine($"PLAYER START : { playerStart}");
            //if (pNameClicked.Name == "name" || pNameClicked.Tag.ToString()!= lbl.Name)
            //    return;
          
            if (lbl.Name == playerStart)
                return;
            lbl.BackColor = Color.Red;
            lbl.ForeColor = Color.White;

        }

        private void RestoreHoverMake(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl.Name == playerStart)
                return;

            lbl.BackColor = Color.Blue;
            lbl.ForeColor = Color.Yellow;
        }

        private void RestoreLabelColor()
        {
            p1Name.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            p2Name.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            p3Name.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
            p4Name.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
        }

        private void PlayerClicked(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;

            RestoreLabelColor();
            if (lbl.Name != pNameClicked.Name)
            {
                lbl.BackColor = Color.Green;
                pNameClicked = lbl;
                
                Console.WriteLine(pNameClicked.Name);
     
                
                Label t = Application.OpenForms["TeamenSelectie"].Controls[lbl.Tag.ToString()] as Label;
            }
            else
            {
                lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000053");
                pNameClicked = new Label();
                pNameClicked.Name = "name";
                pMake = new Label();
            }
        }
        private void PlayerStartClick(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;

            if (pMake.Name == lbl.Name)
            {
                pMake = new Label();
                playerStart = "";
                return;
            }

            pMake.Name = lbl.Name;
            lbl.BackColor = Color.Green;
            playerStart = pMake.Name;

            //   GlobalVars.teamenStartingPlayer = pMake.Name;
        //    f1.SetPlayerStart("peter");
        }
    }
}
