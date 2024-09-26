using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Monster : Character
    {
        protected bool _venomous { get; set; }

        public Monster(string name, int health, int strength)
            : base(name, health, strength)
        {
            this._venomous = new Random().NextDouble() < 0.5;
        }

        public override int GetDamage()
        {
            int damage = base.GetDamage();
            if (_venomous)
            {
                return damage + 5;
            }
            else
            {
                return damage;
            }
        }

    }
}
