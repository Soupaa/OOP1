using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Player : Character
    {
        //fields
        public int _level { get; private set; }
        public int _armor { get; private set; }
        public double _experience { get; private set; }
        public double _experiencebar { get; private set; }

        public Player(string name, int health, int strength, int armor)
            : base(name, health, strength)
        {
            this._level = 1;
            this._armor = 0;
            this._experience = 0;
            this._experiencebar = 100;
        }

        //method
        //offentligt tilgængelig, returnerer ingenting, tager en int som parameter
        public void Level(int expPoint)
        {
            _experience += expPoint;
        }

        private void UpdateLevel() {

            if (_experience >= _experiencebar)
            {
                _level++;
                _experience = 0;
                _experiencebar = 100 + (_level * 1.5);
            }

        }
        public override void UpdateHealth(int value)
        {
            _health += value + _level;
        }

        public int ArmorProtection(int damage)
        {
            int reducedDamage = damage - _armor;
            return reducedDamage > 0 ? reducedDamage : 0;
        }

        //public int Attack()
        //{
        //    Dice dice = new Dice();
        //    int damage = dice.RollDice(1) * _level;
        //    return damage;
        //}

        //tjek om player er død
        public bool IsDead()
        {
            return _health <= 0; 
        }

    }
}
