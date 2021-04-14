using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Menu2
    {
        private String Input;

        public void setInput(String i)
        {
            this.Input = i;
        }

        public String getInput()
        {
            return Input;
        }
        public virtual void ReprintName()
        {
            
            Console.WriteLine("Input Your Name");
            setInput(Input = Convert.ToString(Console.ReadLine()));
            char[] characters = getInput().ToCharArray();
            int total = characters.Count();

            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine("Huruf ke " + i + " adalah " + characters[i - 1]);
            }
        }

        public void Hitung()
        {
            Console.WriteLine("Anda Melakukan Perhitungan");
        }
    }
}
