using System;
using System.Collections;
namespace CollectionsProject
{
    class Program
    {
        static void Main()
        {
            ArrayList list = new ArrayList(2);
            list.Add(100);
            list.Add("hi");

            //Console.WriteLine(list[1]);                 //Accessing elements using index

            Console.WriteLine(list.Capacity); 

            for (int i = 0; i < list.Capacity; i++)
            {
                Console.WriteLine(list[i]+" ");
            }

            foreach(object obj in list)                 //Accessing elements using foreach loop
            {
                Console.Write(obj+" ");
            }

            //list.Insert(2, 300);
            //list.Remove(200);
        }






    }
}