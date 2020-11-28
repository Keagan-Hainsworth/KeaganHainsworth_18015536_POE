using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Hero : Character
    {
        protected Hero(int Ypos, int Xpos): base()
        {
            this.Damage = 2;
            this.y = Ypos;
            this.x = Xpos;
            this.Sym = "H";
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

        public override string ToString()
        {
            string temp = "Player States:" + "\nHP:" + HP + "/" + maxHP + "\n Damage: 2" + "\n" + x + "," + y;
            return temp;
        }
    }
}
