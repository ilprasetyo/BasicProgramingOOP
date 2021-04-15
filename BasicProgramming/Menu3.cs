using System;
using System.Linq;

namespace BasicProgramming
{
    class Menu3: Menu2
    {
        private string Input;

        public override void setInput(string i)
        {
            this.Input = i;
        }

        public override string getInput()
        {
            return Input;
        }

        public override void ReprintName() {
            
            Console.WriteLine("Input Your Name");
            setInput(Input = Convert.ToString(Console.ReadLine()));
            char[] character = getInput().ToCharArray();
            int total = character.Count();

            for (int i = 1; i <= total; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Huruf ke " + i + " adalah " + character[i - 1]);
                }

            }
        }
    }
}
