using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainDelegateDemo
{
    class Program
    {
        public delegate void StringPrinter(string s1);

        static void Main(string[] args)
        {
            var printer = new StringPrinter(PrintString);

            bool esqual = true;

            bool uneqsual = false;

            bool result = esqual & uneqsual;
            if (result)
                printer("Hello");
            else
                printer("bye-bye");

            Console.ReadLine();
            
        }

        static void PrintString(string str)
        {
            Console.WriteLine(str);
        }
    }
}
