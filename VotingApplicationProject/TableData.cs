using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Console = Colorful.Console;

namespace VotingApplicationProject
{
    class TableData
    {
        static int TableWidth = 105;

        public static void PrintSeparator()
        {
            Console.WriteLine(new string('-', TableWidth),Color.BurlyWood);
        }

        public static void PrintRow(params string[] columns)
        {
            int width = (TableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        public static string AlignCentre(string? text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);

            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
