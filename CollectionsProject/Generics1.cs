using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
     class Generics1
    {
        public bool Compare<T>(T a,T b)                       //Generic method using type parameter
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }

        static void Main()
        {
            Generics1 obj = new Generics1();
            Console.WriteLine(obj.Compare<int>(12,12));
            Console.WriteLine(obj.Compare<float>(12f,12f));
        }
    }
}
