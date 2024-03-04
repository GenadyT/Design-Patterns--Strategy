using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCpeciesApp.QuackBehaviors
{
    class SqueakQuack : BL.IQuackBehavior
    {
        public string quack()
        {
            return "Squeak Quack";
        }
    }
}
