using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Leader : Enemy
    {
        public int XPos
        {
            get { return base.x; }
            set { x = value; }
        }

        public int YPos
        {
            get { return base.Y; }
            set { Y = value; }
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

        public Leader(int xPos, int yPos, string symbol) : base(xPos, yPos, symbol)
        {
            XPos = xPos;
            YPos = yPos;
            Symbol = symbol;
            Health = 20;
            MaxHealth = 20;
            dmg = 2;
        }

        public override void ReturnMove(int move)
        {
            switch (move)
            {
                case 0:
                    Y--;
                    break;
                case 1:
                    Y++;
                    break;
                case 2:
                    X++;
                    break;
                case 3:
                    X--;
                    break;
                default:
                    break;
            }
        }
    }
}
