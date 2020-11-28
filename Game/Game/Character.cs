using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public enum Movement
    {
        NoMovement,
        up,
        down,
        left,
        Right,
    }
    abstract class Character : Tile
    {
        protected int HP;
        protected int maxHP;
        protected int Damage;
        protected string Sym;
        protected int Y;
        protected int X;

        //private View[] = new View[];

        protected Character( ) : base()
        {
                       
        }

        public abstract void Pickup(Item i);
        public abstract void Attack(Character target);

        public abstract bool IsDead();

        public abstract bool CheckRange(Character target);

        public abstract int DistanceTo(int x, int y);        

        public abstract void Move();

        public abstract void ReturnMove(int move);
        

        public abstract string ToString();
    }
}
