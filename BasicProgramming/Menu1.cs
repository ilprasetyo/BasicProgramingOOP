using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    public class Menu1
    {
        double weight, height, bmi;
        public void HitungBMI()
        {

            Console.WriteLine("Input Your Weight(Kg) : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Your Height(cm) : ");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = weight / Math.Pow((height/100),2);

            Console.WriteLine("You're BMI Score is " + bmi);

            if (bmi < 18.1)
            {
                Console.WriteLine("You're Underweight");
            }
            else if (bmi > 18.1 && bmi < 23.1)
            {
                Console.WriteLine("You're Normal");
            }
            else if (bmi > 23.1 && bmi < 28.1)
            {
                Console.WriteLine("You're Overweight");
            }
            else if (bmi > 28.1)
            {
                Console.WriteLine("You're Obesitas");
            }

        }
    }
}
