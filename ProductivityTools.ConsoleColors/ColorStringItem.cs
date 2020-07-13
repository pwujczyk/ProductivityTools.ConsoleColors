using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.ConsoleColor
{
    public class ColorStringItem
    {
        public string Value { get; set; }
        public byte? Color { get; set; }

        public ColorStringItem()
        {
            this.Value = string.Empty;
            this.Color = 1;
        }

        public ColorStringItem(string value, byte? color)
        {
            this.Value = value;
            this.Color = color;
        }
    }
}
