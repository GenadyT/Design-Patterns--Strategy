using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCpeciesApp.BL
{
    public class DuckInfo
    {
        private string _title;
        public string Title
        {
            get { return _title; }
        }

        private string _quackBehavior;
        public string QuackBehavior
        {
            get { return _quackBehavior; }
        }

        private string _flyBehavior;
        public string FlyBehavior
        {
            get { return _flyBehavior; }
        }

        private bool _canSwim;
        public bool canSwim
        {
            get { return _canSwim; }
        }

        public DuckInfo(string title, string quackBehavior, string flyBehavior, bool canSwim)
        {
            this._title = title;
            this._quackBehavior = quackBehavior;
            this._flyBehavior = flyBehavior;
            this._canSwim = canSwim;
        }
    }
}
