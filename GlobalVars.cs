using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public static string GenPadding(int car)
        {
            return car.ToString().PadLeft(4, '0');
        }
        public static string HiDafna()
        {
            Console.WriteLine("Hallo skat");
            return "";
        }
    }
}
