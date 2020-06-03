using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    public static class UI
    {
        public static void PrintString(string output)
        {
            Console.WriteLine(output);
        }

        public static string GetUserInput(string output)
        {
            Console.WriteLine(output);
            string input = Console.ReadLine();
            return input;
        }
        public static string GetManagerType()
        {
            string input = GetUserInput("What type of manager would your firm prefer? Queue? Stack?");
            return input;


        }
    }
}
