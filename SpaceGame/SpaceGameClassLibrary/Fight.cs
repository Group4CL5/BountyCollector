using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameClassLibrary
{
    class Fight
    {
        private int answer, input, num1, num2;
        private char op;

        public Fight(char op)
        {
            this.op = op;
            DisplayFight();
        }

        private void DisplayFight()
        {
            generateEquation(out num1, out num2, out answer, op);
            Console.WriteLine($"The equation is: {num1} {op} {num2}");
            Console.Write("What is the answer?: ");
            input = Input();

            if (input == answer)
            {
                Console.WriteLine("Correct answer!");
                DisplayFight();
            }
            else
            {
                Console.WriteLine("Incorrect answer!");
                DisplayFight();
            }
        }
        
        private int Input()
        {
            string temp;
            int anwr;
            do
            {
                temp = Console.ReadLine();
            } while (int.TryParse(temp, out anwr) && anwr <= 0);

            return anwr;
        }

        private void generateEquation(out int x, out int y, out int answer, char op)
        {
            Random rnd = new Random();
            x = rnd.Next(1, 10);

            do
            {
                y = rnd.Next(1, 10);
            } while (op == '/' && y < x);

            switch (op)
            {
                case '+':
                    answer = x + y;
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
    }
}


