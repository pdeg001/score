using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.AddMessageFilter(new MouseMessageFilter());
            MouseMessageFilter.MouseMove += new MouseEventHandler(OnGlobalMouseMove);

            Application.Run(new scorebord());
        }

        static void OnGlobalMouseMove(object sender, MouseEventArgs e)
        {
            //   Console.WriteLine(e.Location.ToString());
            scorebord f1 = (scorebord)Application.OpenForms["scorebord"];
            f1.DisablePromo();
        }
    }
    class MouseMessageFilter : IMessageFilter
    {
        public static event MouseEventHandler MouseMove = delegate { };
        const int WM_MOUSEMOVE = 0x0200;

        public bool PreFilterMessage(ref Message m)
        {

            if (m.Msg == WM_MOUSEMOVE)
            {

                Point mousePosition = Control.MousePosition;

                MouseMove(null, new MouseEventArgs(
                    MouseButtons.None, 0, mousePosition.X, mousePosition.Y, 0));
            }
            return false;
        }
    }
}
