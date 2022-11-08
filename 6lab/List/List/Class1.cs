using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal static class Class1
    {
        public static T[] GetArray<T>(this MyList<T> li)
        {

            return li.ToArray();
        }
    }
}
