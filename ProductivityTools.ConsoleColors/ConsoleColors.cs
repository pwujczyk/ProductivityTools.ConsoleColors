﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.ConsoleColor
{
    public static class ConsoleColors
    {
        //https://jonasjacek.github.io/colors/

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetConsoleMode(IntPtr handle, out int mode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int handle);

        private static void ChangeMode()
        {
            var handle = GetStdHandle(-11);
            int mode;
            GetConsoleMode(handle, out mode);
            SetConsoleMode(handle, mode | 0x4);
        }

        public static void WriteInColor(ColorString input, bool newLine = true)
        {
            ChangeMode();
            foreach (var item in input)
            {
                if (item.Color != null)
                {
                    Console.Write($"\x1b[38;5;{item.Color}m");
                }
                Console.Write(item.Value);
            }
            if (newLine)
            {
                Console.WriteLine();
            }
        }

        public static void WriteInColor(string text, int color, bool newLine = true)
        {
            ChangeMode();
            Console.Write($"\x1b[38;5;{color}m");
            Console.Write(text);

            if (newLine)
            {
                Console.WriteLine();
            }
        }
    }
}
