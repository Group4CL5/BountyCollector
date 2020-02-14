/*
 * BOUNTY COLLECTOR
 * Group 4 - Space Game
 * Collin Handel, Francisco Santillana, Tyler Bia, David Harris, Aaron Miller
 */


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
            if (op == '!')
                _rndOp = true;
            else
            {
                _rndOp = false;
                this._op = op;
            }
        }

        // Returns a string of the generated equation
        public string DisplayFight(Enemy enemy, Player player)
        {
            string text = "";

            text += $"\n\nPlayer Health: {player.Health}  ===  Enemy Health: {enemy.Health}\n\n";

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

        public bool InputAnswer(string inputAnswer)
        {
      
            
                if (_rndOp)
                    return CheckOpAnswer(inputAnswer);
                else
                    return CheckNumAnswer(inputAnswer);
            
            
        }

        // Check the Operator Answer
        public bool CheckOpAnswer(string opInput)
        {
            if (char.TryParse(opInput, out var input))
                return _rndOp && _op == input;
            else
                return false;
        }
        
        // Check the Numeric Answer
        public bool CheckNumAnswer(string numInput)
        {
            if (int.TryParse(numInput, out var input))
                return input == _answer;
            else
                return false;
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
                y = rnd.Next(2, 10);
            } while ((op == '/' && (y > x || (x % y) != 0)) || (op == '-' && y > x));

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