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
        private int menu;

        public void setMenu(int m)
        {
            this.menu = m;
        }

        public int getMenu()
        {
            return menu;
        }
        static void Main()
        {
            Program program = new Program();
            Menu1 menu1 = new Menu1();
            Menu2 menu2 = new Menu2();
            Menu3 menu3 = new Menu3();
            Menu5 menu5 = new Menu5();

            int menu;
            try
            {

            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("1. Body Mas Index");
            Console.WriteLine("2. Reprint Name");
            Console.WriteLine("3. Prints Even's Character");
            Console.WriteLine("4. Sum The Inputted Array");
            Console.WriteLine("5. Calculate Square Number");
            Console.WriteLine("");
            Console.WriteLine("Input Number From 1-5");
            program.setMenu(menu = Convert.ToInt16(Console.ReadLine()));

                switch (program.getMenu())
                {
                    case 1:
                        menu1.HitungBMI();


                        if (menu1.getBmi() < 18.1)
                        {
                            Console.WriteLine("You're Underweight");
                        }
                        else if (menu1.getBmi() > 18.1 && menu1.getBmi() < 23.1)
                        {
                            Console.WriteLine("You're Normal");
                        }
                        else if (menu1.getBmi() > 23.1 && menu1.getBmi() < 28.1)
                        {
                            Console.WriteLine("You're Overweight");
                        }
                        else if (menu1.getBmi() > 28.1)
                        {
                            Console.WriteLine("You're Obesitas");
                        }

                        program.Restart();
                        break;
                    case 2:
                        menu2.Header();
                        menu2.ReprintName();
                        program.Restart();
                        break;
                    case 3:
                        menu3.Header();
                        menu3.ReprintName();
                        //menu3.ReprintEvenName();
                        program.Restart();
                        break;
                    case 4:
                        Menu4 menu4 = new Menu4();
                        program.Restart();
                        break;
                    case 5:
                        menu5.Kuadrat();
                        program.Restart();
                        break;
                    default:
                        Console.WriteLine("Can't Insert "+program.getMenu());
                        Console.WriteLine("Please Insert Number 1-5");
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
