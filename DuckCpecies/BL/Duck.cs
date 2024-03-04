using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCpeciesApp.BL
{
    public abstract class Duck
    {
        protected string _title;

        protected string Title
        {
            get
            {
                //return "I'm " + _title;
                return _title;
            }
        }

        public Duck(string title) { 
            _title = title;
        }

        //public abstract string display();
        public DuckInfo display()
        {
            return new DuckInfo(_title, performQuack(), performFly(), canSwim);
        }

        private const bool CAN_SWIM = true;
        protected bool canSwim {
            get {
                // All duck can swim, even decoys!
                return CAN_SWIM;            
            }
        }
        
        protected IFlyBehavior _flyBehavior;
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            this._flyBehavior = fb;
        }

        protected IQuackBehavior _quackBehavior;
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            this._quackBehavior = qb;
        }
        
        public string performFly()
        {
            return _flyBehavior.fly();
        }

        public string performQuack()
        {
            return _quackBehavior.quack();
        }
    }
}
