using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Menu4
    {
        public  Menu4()
        {
            Console.WriteLine("Input Length Array");
            int input = Convert.ToInt16(Console.ReadLine());
            int[] temp = new int[input];
            int totali = 0;
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine("Insert Number " + i);
                temp[i - 1] = int.Parse(Console.ReadLine());
                totali = totali + temp[i - 1];
            }

            Console.WriteLine("Total Sum = " + totali);
        }
    }
}
