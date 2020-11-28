using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Tile
    {
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
        }
        protected int x
        {
            get;
            set;
        }
        protected int y
        {
            get;
            set;
        }

        protected Tile()
        {
            
        }

    }
}
