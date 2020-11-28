using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Gold : Item
    {
        private Random r;
        private Gold(int xPos, int yPos, int GoldAmount) : base()
        {
            this.XPOS = xPos;
            this.YPOS = yPos;
            GoldAmount = r.Next(1, 5);
        }

        public override string ToString();
    }
}
