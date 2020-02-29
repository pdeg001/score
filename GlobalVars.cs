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
        //public static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public static Boolean autoInnings;
        

    }

    public class Functions
    {
        public static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public static bool osLinux = false;
        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        public static int mMinute, mHour = 0;
      
        
        public static string GenPadding(int car)
        {
            return car.ToString().PadLeft(3, '0');
        }

        public static void CheckOsLinux()
        {
            int p = (int)Environment.OSVersion.Platform;
            if (p == 4 || p == 6 || p == 128)
            {
                osLinux = true;
            }
        }
        

        public static string GetConfigFile()
        {
            if (osLinux)
            {
                string linuxPath = @"/home/pi/score/cnf.44";
                return linuxPath;
               // Console.WriteLine(projectDirectory);
                //return "cnf.44";
            } else
            {
                return Path.Combine(projectDirectory,@"","cnf.44");
            }
        }

        public static string GetAppPath()
        {
            if (osLinux)
            {
                return @"/home/pi/score/";
            }
            else
            {
                return Path.Combine(projectDirectory, @"", "");
            }
        }

        public static string GetFontFile()
        {
         ///   string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
         ///   return Path.Combine(projectDirectory, @"fonts\", "digital-7.ttf");
            //return Path.Combine(projectDirectory, @"fonts\", "dsdigi.ttf");

         
            if (osLinux)
            {
                return @"/home/pi/score/fonts/digital-7.ttf";
            }
            else
            {
                return Path.Combine(projectDirectory, @"fonts\", "digital-7.ttf");
            }

        }

        public static string GetMoyenne(string moyenne)
        {
            return moyenne;
        }

        public static Image GetImgCheckMark()
        {
            if (osLinux)
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
            if (osLinux)
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"/home/pi/score/images/", "biljarter.png"));
            }
            else
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", "biljarter.png"));
            }
        }


        public static Image GetPromoLogo()
        {
            if (osLinux)
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"/home/pi/score/images/", "UwLogo.png"));
            }
            else
            {
                return Image.FromFile(Path.Combine(projectDirectory, @"images\", "UwLogo.png"));
            }
        }

        public static Image GetImgStartPartij()
        {
            if (osLinux)
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
            if (osLinux)
            {
                return "/home/pi/score/images/mouse.cur";
            }
            else
            {
                return Path.Combine(projectDirectory, @"images\", "mouse.cur");
            }
        }

        public static Image GetImgKraai()
        {
        if (osLinux)
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


        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
               // Console.WriteLine("INTERNET");
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                Console.WriteLine("NO INTERNET");
                return false;
            }
        }
    }

    

}