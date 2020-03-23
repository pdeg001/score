using System.Windows.Forms;

namespace peter
{
    public class TeamSelectionPlayers
    {
        private static string p1;
        private static string p1Make;
        private static string p1Carom;
        private static string p2;
        private static string p2Make;
        private static string p2Carom;

        private static string pStart;

        public static string P1 { get => p1; set => p1 = value; }
        public static string P1Make { get => p1Make; set => p1Make = value; }
        public static string P2 { get => p2; set => p2 = value; }
        public static string P2Make { get => p2Make; set => p2Make = value; }
        public static string PStart { get => pStart; set => pStart = value; }
        public static string P1Carom { get => p1Carom; set => p1Carom = value; }
        public static string P2Carom { get => p2Carom; set => p2Carom = value; }

        public static void RestoreLabelColorMake(Label lbl)
        {
            lbl.BackColor = System.Drawing.ColorTranslator.FromHtml("#000AFF");
            lbl.ForeColor = System.Drawing.Color.Yellow;
        }
    }
}
