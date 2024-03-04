using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QB = DuckCpeciesApp.QuackBehaviors;
using FB = DuckCpeciesApp.FlyBehaviors;

namespace DuckCpeciesApp.Ducks
{
    class RedHeadDuck : BL.Duck
    {
        public RedHeadDuck() : base("RedHead Duck")
        {
            this._quackBehavior = new QB.SimpleQuack();
            this._flyBehavior = new FB.FlyWithWings();
        }
    }
}
