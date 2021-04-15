using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Menu2
    {
        private string Input;

        public virtual void setInput(string i)
        {
            this.Input = i;
        }

        public virtual string getInput()
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

        public void Header()
        {
            Console.WriteLine("Anda Melakukan Aktivitas Reprint Name");
            Console.WriteLine("------------------------------------------");
        }
    }
}
