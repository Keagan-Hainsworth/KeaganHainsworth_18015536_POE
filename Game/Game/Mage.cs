using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
     class Mage : Enemy
    {
        public int XPos
        {
            get { return base.x; }
            set { x = value; }
        }

        public int YPos
        {
            get { return base.y; }
            set { y = value; }
        }

        public string Symbol
        {
            get { return base.Sym; }
            set { Sym = value; }
        }
        public int Health
        {
            get { return base.HP; }
            set { HP = value; }
        }
        public int MaxHealth
        {
            get { return base.maxHP; }
            set { maxHP = value; }

        }
        public int dmg
        {
            get { return base.Damage; }
            set { Damage = value; }
        }
        public Mage(int xPos, int yPos, string symbol) : base(xPos, yPos, symbol)
        {
            XPos = xPos;
            YPos = yPos;
            Symbol = symbol;
            Health = 5;
            MaxHealth = 5;
            dmg = 5;
        }

        public override void ReturnMove(int move)
        {
            move = 0;
        }
    }
}
