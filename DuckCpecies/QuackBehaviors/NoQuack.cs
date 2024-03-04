using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCpeciesApp.QuackBehaviors
{
    class NoQuack : BL.IQuackBehavior
    {
        public string quack()
        {
            return "No Quack";
        }
    }
}
