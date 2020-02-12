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
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;

namespace peter
{
    public class GlobalVars
    {
        
        public static string str = "peter";
        public static int p1Caroms = 0;
        public static int p2Caroms = 0;
        public static int carom;
        public static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public static Boolean autoInnings;

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

        public static string GetMouseCoursorPath()
        {
            int p = (int)Environment.OSVersion.Platform;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            if (p == 4 || p == 6 || p == 128)
            {
                //return Path.Combine(projectDirectory, @"/home/pi/score/images/", "mouse.cur");
                return "/home/pi/score/images/mouse.cur";
            }
            else
            {
               // return Path.Combine(projectDirectory, @"images\", "mouse.cur");
                return Path.Combine(projectDirectory, @"images\", "mouse.cur");
            }
        }

        public static Image GetImgKraai()
        {
            int p = (int)Environment.OSVersion.Platform;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

            if (p == 4 || p == 6 || p == 128)
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"/home/pi/score/images/", "ODT0.gif"));
            }
            else
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", "ODT0.gif"));
            }
        }

        public static string GetIP()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
           // string myIP = Dns.GetHostEntry(hostName).AddressList[1].ToString();
            Console.WriteLine("My IP Address is :" + myIP);

            return $"{myIP}";

        }


        public static Form GetScoreBordForm()
        {
            scorebord f1 = (scorebord)Application.OpenForms["scorebord"];
            return f1;
        }

    }

}