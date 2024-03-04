using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QB = DuckCpeciesApp.QuackBehaviors;
using FB = DuckCpeciesApp.FlyBehaviors;
using DuckCpeciesApp.BL;

namespace DuckCpeciesApp.Ducks
{
    class DecoyDuck : BL.Duck
    { 
        public DecoyDuck() : base("Decoy Duck") 
        {
            this._quackBehavior = new QB.SimpleQuack();
            this._flyBehavior = new FB.NoFly();
        }
    }
}
