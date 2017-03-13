using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HashTablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            String b = "Bul";
           Hashtable myHashtable = new Hashtable();
            myHashtable.Add(a,"BITM");
            myHashtable.Add(b, "Hasan");

            Console.WriteLine(myHashtable[1]);
            Console.WriteLine(myHashtable["Bul"]);

            Console.WriteLine(myHashtable.ContainsValue("BITM"));

            foreach (DictionaryEntry dictionaryEntry in myHashtable)
            {
                Console.WriteLine(dictionaryEntry.Key+"-"+dictionaryEntry.Value);
            }

            /*Dictionary<int,String> mydDictionary = new Dictionary<int, string>();
            mydDictionary.Add(1,"Adbullah");
            mydDictionary.Add(2,"Al");
            mydDictionary.Add(3,"Hasan");

            foreach (KeyValuePair<int, string> keyValuePair in mydDictionary)
            {
                Console.WriteLine(keyValuePair.Key+" - "+keyValuePair.Value);
            }*/

            //dynamic myDynamic = new System.Dynamic.ExpandoObject();

            //var mydictionary = new Dictionary<int, dynamic>();

            //mydictionary[1] = myDynamic;
            //mydictionary[1].FirstName = "Abdulllah";
            //mydictionary[1].MiddleName = "Al";
            //mydictionary[1].LastName = "Hasan";

            //Console.WriteLine(mydictionary[1].FirstName+" "+mydictionary[1].MiddleName+" "+mydictionary[1].LastName);

            //String[] myName = {"Abdullah", "Al", "Hasan"};

            //Dictionary<int,String[]> myStringses = new Dictionary<int, string[]>();

            //mydictionary.Add(1,myStringses[0]);
            //mydictionary.Add(1, myStringses[1]);
            //mydictionary.Add(1, myStringses[2]);

            //foreach (KeyValuePair<int, string[]> keyValuePair in myStringses)
            //{
            //    Console.WriteLine(keyValuePair.Key+" "+keyValuePair.Value);
            //}
            Console.ReadKey();
        }
    }
}
