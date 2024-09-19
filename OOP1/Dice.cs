using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Dice
    {
        private static Random _random = new Random();
        private int _result;

        public Dice()
        {
            _result = 1;
        }

        public int Result
        {
            get { return _result; }
        }

        public void Roll()
        {
            _result = _random.Next(1, 7);
            Console.WriteLine("The dice rolled: " + _result);
        }

        public int RollDice(int amount)
        {
            //int amount = 4;
            Random r = new Random();
            int total = 0;

            List<int> dice = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                dice.Add(r.Next(1, 7));
            }

            foreach (int die in dice)
            {
                total += die;
                //Console.WriteLine(die);
            }

            return total;

        }
    }
}
