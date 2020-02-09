using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Drawing;

namespace peter
{
    public class GlobalVars
    {
        
        public static string str = "peter";
        public static int p1Caroms = 0;
        public static int p2Caroms = 0;
        public static int carom;
        public static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
    }

    public class Functions
    {
        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        public static int mMinute, mHour = 0;
        public static string GenPadding(int car)
        {
            return car.ToString().PadLeft(3, '0');
        }

        public static string GetP1Carom(int lblTag)
        {
            return "00";
        }

        public static string GetFontFile()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            return Path.Combine(projectDirectory, @"fonts\", "digital-7.ttf");
           //return Path.Combine(projectDirectory, @"fonts\", "dsdigi.ttf");
        }

        public static string GetMoyenne(string moyenne)
        {
            return moyenne;
        }

        public static Image GetImgCheckMark()
        {
            int p = (int)Environment.OSVersion.Platform;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            if (p == 4 || p == 6 || p == 128)
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"/home/pi/score/images/", "check.jpg"));
            }
            else
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", "check.jpg"));
            }
        }

        public static Image GetImgLogo()
        {
            int p = (int)Environment.OSVersion.Platform;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            if (p == 4 || p == 6 || p == 128)
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"/home/pi/score/images/", "biljarter.png"));
            }
            else
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", "biljarter.png"));
            }
        }

        public static Image GetImgStartPartij()
        {
            int p = (int)Environment.OSVersion.Platform;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            if (p == 4 || p == 6 || p == 128)
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"/home/pi/score/images/", "start_partij.png"));
            }
            else
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", "start_partij.png"));
            }
        }

        public static Image GetMouseCoursorImg()
        {
            int p = (int)Environment.OSVersion.Platform;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            if (p == 4 || p == 6 || p == 128)
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"/home/pi/score/images/", "mouse.png"));
            }
            else
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", "mouse.png"));
            }
        }

    }

}