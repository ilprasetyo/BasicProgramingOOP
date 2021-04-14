using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace BasicProgramming
{
   
    
    class Program
    {
        public void Restart()
        {
            String restart;
            Console.WriteLine("........");
            Console.WriteLine("Type Yes to restart program");
            restart = Console.ReadLine();

            if (restart.ToUpper() == "YES")
            {
                Main();
            }
        }

        static void Main()
        {
            Program program = new Program();
            Menu1 menu1 = new Menu1();
            Menu2 menu2 = new Menu2();
            Menu3 menu3 = new Menu3();
            Menu4 menu4 = new Menu4();

            try
            {
            int menu;

            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("1. Body Mas Index");
            Console.WriteLine("2. Reprint Name");
            Console.WriteLine("3. Prints Even's Character");
            Console.WriteLine("4. Sum The Inputted Array");
            Console.WriteLine("");
            Console.WriteLine("Input Number From 1-4");
            menu = Convert.ToInt16(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        menu1.HitungBMI();
                        program.Restart();
                        break;
                    case 2:
                        menu2.ReprintName();
                        Console.WriteLine("-------------------");
                        Console.WriteLine(menu2.getInput());
                        program.Restart();
                        break;
                    case 3:
                        menu3.ReprintName();
                        //menu3.ReprintEvenName();
                        program.Restart();
                        break;
                    case 4:
                        menu4.SumInputArray();
                        program.Restart();
                        break;
                }

            } 
            catch (FormatException)
            {
                Console.WriteLine("Please Insert Number, Not Alphabet");
                program.Restart();

            }


        }


    }
}
