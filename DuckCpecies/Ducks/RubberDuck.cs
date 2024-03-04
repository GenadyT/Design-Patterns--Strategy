using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QB = DuckCpeciesApp.QuackBehaviors;
using FB = DuckCpeciesApp.FlyBehaviors;

namespace DuckCpeciesApp.Ducks
{
    class RubberDuck : BL.Duck
    {
        public RubberDuck() : base("Rubber Duck")
        {
            this._quackBehavior = new QB.SqueakQuack();
            this._flyBehavior = new FB.NoFly();
        }
    }
}
