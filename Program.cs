using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpharator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;            
            while(!exit)
            {
                 PrintMenu(); //UI 
                 exit = Work();  //start

            }
        }
        public static Boolean Work()
        {
            bool exit = false;
            string alphabets = " ";
            int choice = 0;
            try
            {
                 choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Input, Try again!");
            }
            switch(choice)
            {
                case 1:
                    Console.WriteLine("\t\t\t\t");
                    alphabets =  GenerateAlphabets('a', 'z');
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(alphabets);
                    break;
                case 2:
                    Console.WriteLine("\t\t\t\t");
                    alphabets = GenerateAlphabets('A', 'Z');
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(alphabets);
                    break;
                case 3:
                    Console.WriteLine("\t\t\t\t");
                    alphabets =  " Lower Case  [" + GenerateAlphabets('a', 'z') + "] \n Upper Case {" + GenerateAlphabets('A', 'Z') + "} ";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(alphabets);                    
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Quitting Application!");
                    exit = true;
                    break;
                    

             }
            return exit;

        }

        public static string GenerateAlphabets(char startChar, char endingChar)
        {
            string alphabets ="";
            for(char letter = startChar; letter <= endingChar; letter++)
            {
                alphabets += letter + " ";
            }
            return alphabets;

        }





        public static void PrintMenu()
        {
            Console.WriteLine("\t\t\t\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t WELCOME TO ALPHARATOR!!!!!");
            Console.WriteLine("\t\t\t\t");
            Console.WriteLine("\t\tUpper Case Lower Case Alphabet Generator In C#");
            Console.WriteLine("                                                  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 1 For Lower Case Alphabets");
            Console.WriteLine("\t\t\t\t");
            Console.WriteLine("Press 2 for UPPER CASE ");
            Console.WriteLine("\t\t\t\t");
            Console.WriteLine("Press 3 For Both Lower and Upper Case Alphabets");
            Console.WriteLine("\t\t\t\t");
            Console.WriteLine("Press 4 to Quit");

               
        }

    }
}
