using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Weapon : Item
    {
        public string WeaponType
        {
            get { }
            set { }
        }

        public int Damage
        {
            get { }
            set { }
        }

        public int Range
        {
            get { }
            set { }
        }

        public int Cost
        {
            get { }
            set { }
        }
    }
}
