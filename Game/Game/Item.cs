using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    abstract class Item : Tile
    {       
        public int XPOS
        {
            get { return base.x; }
            set { x = value; }
        }

        public int YPOS
        {
            get { return base.y; }
            set { y = value; }
        }
        public Item() : base()
        {
            
        }
        public abstract override string ToString();


    }
}
