using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Character
    {
        protected string _name { get; set; }
        protected int _health { get; set; }
        protected int _strength { get; set; }

        public Character(string name, int health, int strength)
        {
            this._name = name;
            this._health = health;
            this._strength = strength;

        }

        public virtual void UpdateHealth(int value)
        {
            _health += value;
        }

        public virtual int GetDamage()
        {
            return _strength;
        }

        public virtual string GetName() {
            return _name;
        }

        public virtual int GetHealth() {
            return _health;
        }
    }
}
