using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public static class Utils
    {
        public static void WriteColorized(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void WriteColoredBoolean(string boolean, bool? useYesNo)
        {
            bool bool1 = bool.Parse(boolean);
            if (useYesNo??false) WriteColorized(bool1?"Yes":"No", bool1 ? ConsoleColor.Green : ConsoleColor.Red);
            else WriteColorized(bool1.ToString(), bool1 ? ConsoleColor.Green : ConsoleColor.Red);
        }

        public static string FirstUpperCase(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1, text.Length-1);
        }
    }
}
