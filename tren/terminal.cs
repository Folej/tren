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

                switch(OneCase.ToLower())
                {
                    case "create new":                    
                        Console.WriteLine("enter the name of new the database");
                        string NameDB = Console.ReadLine();

                        Console.WriteLine("enter the path");
                        string PathDir = Console.ReadLine();

                        Console.WriteLine("create a given directory (Yes or No) ?");
                        string otv = Console.ReadLine();

                        if (otv == "Yes" || otv == "yes" || otv == "y" || otv == "Y")
                        {
                            bool exist = Directory.Exists(PathDir);

                            if (!exist)
                            {
                                Console.WriteLine(PathDir + " does not exist.");
                                Console.WriteLine("Create directory: " + PathDir);

                                Directory.CreateDirectory(PathDir);
                            }

                            else
                            {
                                Console.WriteLine("error: this directive already exists!");
                            }
                        }
                        
                        else
                        {
                            Console.WriteLine("cancellation");
                        }
                    break;

                    case "--help":                    
                        Console.WriteLine("");
                    break;

                    case "--info":                    
                        Console.WriteLine("version -- 0.0.0 (beta)");
                        Console.WriteLine("date launch -- " + date);
                    break;

                    case "/exit":
                    
                        Environment.Exit(0);
                    break;
                }
            }
        }
    }
}
