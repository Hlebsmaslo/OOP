using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class MyClass<T>
    {
        public static T FactoryMethod<T>() where T : new()
        {
            var a = new T();
            return a;
        }


    }
}
