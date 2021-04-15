using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Menu5
    {
        static int KuadratMethod(int x)
        {
            return x * x;
        }

        static double KuadratMethod(double x)
        {
            return x * x;
        }

        public void Kuadrat()
        {
            Console.WriteLine("Input Integer Number ");
            int angka1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input Decimal Number ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            int num1 = KuadratMethod(angka1);
            double num2 = KuadratMethod(angka2);

            Console.WriteLine("Square Result Integer  "+num1);
            Console.WriteLine("Square Result Decimal "+num2);
        }
    }
}
