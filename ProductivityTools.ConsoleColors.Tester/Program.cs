using System;
using System.Drawing;

namespace ProductivityTools.ConsoleColor.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new ColorString();
            for (byte i = 0; i < 255; i++)
            {
                text.Add(new ColorStringItem(i.ToString().PadLeft( 10,' '),15));
                text.Add(new ColorStringItem(" XXXX", i));
            }

            ConsoleColors.WriteInColor(text);
            Console.Read();
        }
    }
}
