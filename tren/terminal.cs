using System;
using System.IO;

namespace TerminalProgramm
{
    class program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("The terminal is running!");

            DateTime date = DateTime.Now;
            byte ConsolStart = 1;            

            while (ConsolStart == 1)
            {
                Console.WriteLine("Terminal OCRO DataBase: ");
                string OneCase = Console.ReadLine();

                if (OneCase == "create new DB")
                {
                    Console.WriteLine("enter the name of new the database");
                    string NameDB = Console.ReadLine();

                    Console.WriteLine("enter the path");
                    string PathDB = Console.ReadLine();

                    
                }

                else if (OneCase == "--help")
                {
                    Console.WriteLine("");
                }

                else if (OneCase == "--info")
                {
                    Console.WriteLine("version -- 0.0.0 (beta)");
                    Console.WriteLine("date launch -- " + date);
                }

                else
                {
                    Console.WriteLine("error: is not an internal command!");
                }
            }
        }
    }
}
