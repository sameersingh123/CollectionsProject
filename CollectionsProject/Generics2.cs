using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class Generics2<T>                      //Generic class using type parameter
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Subtract(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Multiply(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Divide(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
    class TestGenerics
    {

    

        static void Main()
        {
            Generics2<int> obj = new Generics2<int>();           //exactly like Generic List Collection 
            obj.Add(10, 20);
            obj.Subtract(20, 10);
            obj.Multiply(10, 20);
            obj.Divide(20, 10);

           

        }
    }
}
