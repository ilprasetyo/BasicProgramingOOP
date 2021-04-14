using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    public class Menu1
    {
        private double weight, height, bmi;

        public void setWeight(double w)
        {
            this.weight = w;
        }

        public double getWeight()
        {
            return weight;
        }

        public void setHeight(double h)
        {
            this.height = h;
        }

        public double getHeight()
        {
            return height;
        }

        public void setBmi(double i)
        {
            this.bmi = i;
        }

        public double getBmi()
        {
            return bmi;
        }
        public void HitungBMI()
        {

            Console.WriteLine("Input Your Weight(Kg) : ");
            setWeight(weight = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Input Your Height(cm) : ");
            setHeight(height = Convert.ToDouble(Console.ReadLine()));

            setBmi(bmi = getWeight() / Math.Pow((getHeight()/100),2));

            Console.WriteLine("You're BMI Score is " + getBmi());

        }
    }
}
