using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTHREE
{
    internal class what
    {
        private decimal aa;
        private string bb;
        private int cc;
        public virtual decimal A
        {
            get
            {
                return aa;
            }
        }
        public virtual string B
        {
            get
            {
                return bb;
            }
            set { bb = value; }
        }
        public virtual int C
        {
            get
            {
                return cc;
            }
            set
            {
                cc = value;
            }
        }
        public what(int c, decimal a)
        {
            cc = c;
            aa = a;
        }
    }
}
