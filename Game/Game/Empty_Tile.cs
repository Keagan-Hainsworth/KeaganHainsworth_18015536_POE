using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Empty_Tile : Tile 
    {
        public Empty_Tile(int Xpos, int Ypos) : base()
        {
            this.x = Xpos;
            this.y = Ypos;
        }
    }
}
