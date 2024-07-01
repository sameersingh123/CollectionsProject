using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
     class DictionaryCollections
    {
        static void Main()
        {
            Dictionary<string,object> dict= new Dictionary<string,object>();
            dict.Add("EmpId", 101);
            dict.Add("EmpName", "David");
            dict.Add("EmpSal", 50000);
            dict.Add("Dept", "Engg");

            foreach(string key in dict.Keys)
            {
                Console.WriteLine(key+": " + dict[key]);
            }
        }
    }
}
