//using System;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;

//namespace SpaceGameClassLibrary
//{
//    class Fight
//    {
//        private int _answer, _numInput, _opInput, _num1, _num2;
//        private char _op;
//        //private readonly Player player = new Player();
//        //private readonly Enemy enemy = new Enemy(5);
//        readonly Random rnd = new Random();
//        private readonly char[] _allOps = { '+', '-', '*', '/' };
//        private readonly bool _rndOp;

//        public Fight()
//        {
//            _rndOp = true;
//            DisplayFight();
//        }

//        public Fight(char op)
//        {
//            _rndOp = false;
//            this._op = op;
//            DisplayFight();
//        }

//        public string DisplayFight()
//        {
//            string text = "";

//            text += $"\n\nPlayer Health: {player.Health}  ===  Enemy Health: {enemy.Health}";

//            if (_rndOp)
//                _op = _allOps[rnd.Next(0, 3)];

//            GenerateEquation(out _num1, out _num2, out _answer, _op);

//            if (!_rndOp)
//            {
//                text += $"The equation is: {_num1} {_op} {_num2}";
//            }
//            else
//            {
//                text += $"The equation is: {_num1} _ {_num2} = {_answer}";
//            }
//        }

//        public bool CheckAnswer()
//        {
//            if ((_rndOp && _op == _opInput) || _numInput == _answer)
//            {
//                Console.WriteLine("Correct answer!");
//                enemy.LoseHealth(1);

//                if (!enemy.IsDead())
//                    DisplayFight();
//                else
//                    Console.WriteLine("The enemy has died!");
//            }
//            else
//            {
//                Console.WriteLine("Incorrect answer!");

//                player.LoseHealth(1);

//                if (!player.IsDead())
//                    DisplayFight();
//                else
//                    Console.WriteLine("You have died...");
//            }
//        }

//        private int NumInput()
//        {
//            string temp;
//            int anwr;

//            do
//            {
//                Console.Write("What is the answer?: ");
//                temp = Console.ReadLine();
//            } while (!int.TryParse(temp, out anwr));

//            return anwr;
//        }

//        private char OpInput()
//        {
//            string temp;
//            char anwr;

//            do
//            {
//                Console.Write("What is the answer?: ");
//                temp = Console.ReadLine();
//            } while (!char.TryParse(temp, out anwr) || !_allOps.Contains(anwr));

//            return anwr;
//        }

//        private void GenerateEquation(out int x, out int y, out int answer, char op)
//        {
//            x = rnd.Next(1, 10);

//            do
//            {
//                y = rnd.Next(1, 10);
//            } while ((op == '/' && (y > x || (x % y) != 0) || y == 1) || (op == '-' && y > x));

//            switch (op)
//            {
//                case '+':
//                    answer = x + y;
//                    break;
//                case '-':
//                    answer = x - y;
//                    break;
//                case '*':
//                    answer = x * y;
//                    break;
//                case '/':
//                    answer = x / y;
//                    break;
//                default:
//                    answer = 0;
//                    break;
//            }
//        }
//    }
//}