using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    public class Class2
    {
        public event EventHandler<ActionEventArgs> actadd;
        public event EventHandler<ActionEventArgs> compl;
        public event EventHandler workcompl;
        private enum State
        {
            ad,
            exact,
            workc
        }
        private State cst = State.ad;
        public void Run()
        {
            var a1 = new Class1("Action 1");
            var a2 = new Class1("Action 2");
            var a3 = new Class1("Action 3");
            var a4 = new Class1("Action 4");
            AdddAc(a1);
            AdddAc(a2);
            AdddAc(a3);
            AdddAc(a4);
            while (cst != State.workc)
            {
                switch (cst)
                {
                    case State.ad:
                        cst = State.exact;
                        break;
                    case State.exact:
                        a1.Ex();
                        a2.Ex();
                        a3.Ex();
                        a4.Ex();
                        cst = State.workc;
                        break;
                }
            }
            wc();
        }
        private void AdddAc(Class1 action)
        {
            aa(action);
            ac1(action);
        }
        protected virtual void aa(Class1 action)
        {
            actadd?.Invoke(this, new ActionEventArgs(action));
        }
        protected virtual void ac1(Class1 action)
        {
            compl?.Invoke(this, new ActionEventArgs(action));
        }
        protected virtual void wc()
        {
            workcompl?.Invoke(this, EventArgs.Empty);
        }
    }
}
