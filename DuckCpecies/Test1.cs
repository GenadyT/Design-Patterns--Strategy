using DuckCpeciesApp.BL;
using DuckCpeciesApp.Controls;
using DuckCpeciesApp.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Test1
    {
        public static void Run(DackListView dvl)
        {
            Duck duck;            

            duck = new DecoyDuck();
            dvl.AddItem(duck.display());

            duck = new RubberDuck();
            dvl.AddItem(duck.display());

            duck = new RedHeadDuck();
            dvl.AddItem(duck.display());

            duck = new MallardDuck();
            dvl.AddItem(duck.display());

            //-------------------------------

            /*Duck mallard = new MallardDuck();
            string pq = mallard.performQuack();
            string pf = mallard.performFly();
            textBox1.Text = string.Format("pq: {0},  pf: {1}", pq, pf);*/
        }
    }
}
