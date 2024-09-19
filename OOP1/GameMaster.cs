using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class GameMaster
    {
        public GameMaster() { }


        public void Encounter(Player playerOne,Player playerTwo, Dice dice) {
            //Dice dice = new Dice();
            //Random rand = new Random();

            //Player hero = new Player("siegfried", 20);
            //Player enemy = new Player("Fafnir", 50);


            Console.WriteLine($"{playerOne._playername} encounters {playerTwo._playername}: What shall he do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");
            string choice = Console.ReadLine().ToLower();

            if (choice == "1" || choice == "attack")
            {
                Console.WriteLine("You attack the enemy!");
                Fight(playerOne, playerTwo, dice);
            }
            else
            {
                Console.WriteLine($"You tried to run away, but {playerTwo._playername} won't allow it!");
                Fight(playerOne, playerTwo, dice);
            }



        }

        public void Fight(Player x, Player y, Dice z) {

            Random rand = new Random();

            Console.WriteLine(x._playername + " and " + y._playername + " finally faced off!");
            Console.WriteLine(x._playername + ": You shall taste my steel, monster!");
            Console.WriteLine(y._playername + ": *Homicidal roar*");

            do
            {
                bool heroTurn = true;
                bool enemyTurn = false;
                int heroattack = z.RollDice(rand.Next(1, 3));
                int enemyattack = z.RollDice(rand.Next(1, 3));
                if (heroTurn)
                {
                    Console.WriteLine("It's " + x._playername + "'s turn!\n");
                    Console.WriteLine($"You have {x._health} health remaining.");
                    Console.WriteLine("Press any key to roll the dice to determine the damage!");
                    Console.ReadLine();
                    y.UpdateHealth(-heroattack);
                    Console.WriteLine("You dealt " + heroattack + " damage to " + y._playername + "!");
                    Console.ReadLine();

                    heroTurn = false;
                    enemyTurn = true;
                }

                if (enemyTurn)
                {
                    Console.WriteLine("It's " + y._playername + "'s turn!");
                    Console.WriteLine($"The enemy have {y._health} health remaining.");
                    x.UpdateHealth(-enemyattack);
                    Console.WriteLine(y._playername + " dealt " + enemyattack + " damage to " + x._playername + "!");
                    Console.ReadLine();

                    heroTurn = true;
                    enemyTurn = false;
                }

            } while (!x.IsDead() && !y.IsDead());

            if (x.IsDead() && y.IsDead())
            {
                Console.WriteLine(y._playername + " and " + x._playername + "both died ....... BOOO");
            }
            else if (x.IsDead())
            {
                y.Level(10);
                Console.WriteLine($"{y._playername} kills {x._playername}. {y._playername} gains 10 exp. They have total of: {y._experience} exp.");

            }
            else
            {
                x.Level(10);
                Console.WriteLine($"{x._playername} kills {y._playername}. {x._playername} gains 10 exp. They have total of: {x._experience} exp.");

            }
        }
    }
}
