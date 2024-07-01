using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
     class HashCollection
    {
        static void Main()
        {
            Hashtable hash = new Hashtable();
            hash.Add("EmpId", 101);
            hash.Add("EmpName", "David");
            hash.Add("EmpSal", 50000);
            hash.Add("Dept", "Engg");

            Console.WriteLine(hash["EmpId"]);

            //for (int i = 0; i < hash.Count; i++)       //
            //{
            //    Console.WriteLine(hash[i]);
            //}

            foreach (object key in hash.Keys)
            {
                Console.WriteLine(key + ": " + hash[key]);
            }
        }
        

    }
}
