using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameMaster game = new GameMaster();
            Dice dice = new Dice();
            Random rand = new Random();

            Player hero = new Player("siegfried", 50, 20, 20);
            Player enemy = new Player("Fafnir", 50, 25, 15);

            game.Encounter(hero, enemy, dice);

        }
    }
}


