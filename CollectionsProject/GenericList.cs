using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
     class GenericList
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);

            li.Insert(3, 35);
            li.Remove(20);


            for (int i=0;i<li.Count;i++)             //accessing elements using index just like arrays   Count is a property here
            {
                Console.WriteLine(li[i]+" ");
            }

            foreach(int i in li)
            {
                Console.WriteLine(i+" ");
            }

            
        }
    }
}
