using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace SpaceGameClassLibrary
{
    public class Fight
    {
        private int _answer, _num1, _num2;
        private char _op;
        readonly Random rnd = new Random();
        private readonly char[] _allOps = { '+', '-', '*', '/' };
        private readonly bool _rndOp;

        public Fight()
        {
            _rndOp = true;
        }

        public Fight(char op)
        {
            _rndOp = false;
            this._op = op;
        }

        // Returns a string of the generated equation
        public string DisplayFight(Enemy enemy, Player player)
        {
            string text = "";

            text += $"\n\nPlayer Health: {player.Health}  ===  Enemy Health: {enemy.Health}";

            if (_rndOp)
                _op = _allOps[rnd.Next(0, 3)];

            GenerateEquation(out _num1, out _num2, out _answer, _op);

            if (!_rndOp)
            {
                text += $"The equation is: {_num1} {_op} {_num2}";
            }
            else
            {
                text += $"The equation is: {_num1} _ {_num2} = {_answer}";
            }

            return text;
        }

        // Check the Operator Answer
        public bool CheckOpAnswer(char opInput)
        {
            return _rndOp && _op == opInput;
        }
        
        // Check the Numeric Answer
        public bool CheckNumAnswer(int numInput)
        {
            return numInput == _answer;
        }

        private int NumInput()
        {
            string temp;
            int anwr;

            do
            {
                Console.Write("What is the answer?: ");
                temp = Console.ReadLine();
            } while (!int.TryParse(temp, out anwr));

            return anwr;
        }

        private char OpInput()
        {
            string temp;
            char anwr;

            do
            {
                Console.Write("What is the answer?: ");
                temp = Console.ReadLine();
            } while (!char.TryParse(temp, out anwr) || !_allOps.Contains(anwr));

            return anwr;
        }

        // Check the equation
        private void GenerateEquation(out int x, out int y, out int answer, char op)
        {
            x = rnd.Next(1, 10);

            // Keep generating value Y if
            //      Division:
            //         - Y is greater than X 
            //         - X % Y does not equal 0
            //         - Y == 1
            //      Subtraction:
            //         - Y is greater than X 
            //         - X % Y does not equal 0
            do
            {
                y = rnd.Next(1, 10);
            } while ((op == '/' && (y > x || (x % y) != 0) || y == 1) || (op == '-' && y > x));

            switch (op)
            {
                case '+':
                    answer = x + y;
                    break;
                case '-':
                    answer = x - y;
                    break;
                case '*':
                    answer = x * y;
                    break;
                case '/':
                    answer = x / y;
                    break;
                default:
                    answer = 0;
                    break;
            }
        }
    }
}