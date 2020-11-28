using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Enemy : Character
    {        
        public Enemy(int x, int y, string Symbol) : base()
        {            
            this.X = x;
            this.Y= y;            
            this.Sym = Symbol;
        }
        public abstract override string ToString();
        

    }
}
