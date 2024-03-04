using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCpeciesApp.FlyBehaviors
{
    class NoFly : BL.IFlyBehavior
    {           
        public string fly()
        {
            return "Can't fly";
        }
    }
}
