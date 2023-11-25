using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[10];
            array[0] = 1;
            array[1] = 2;
            Console.ReadLine();

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Test");
            arrayList.Add(10.50);

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Number", 1);
            hashtable.Add("Name", "Test");

            List<string> str = new List<string>();
            str.Add("Name1");
            str.Add("Name2");

            foreach(var item in str)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Name1");
            keyValuePairs.Add(2, "Name2");

            foreach(KeyValuePair<int,string> keyValuePair in keyValuePairs)
            {
                Console.WriteLine($" {keyValuePair.Key} {keyValuePair.Value}");
            }

            IEnumerable<string> list = from s in str
                                       where s == "Name1"
                                       select s;

            List<string> list2 = str.FindAll(x => x == "Name1");

            List<int> numbers = new List<int> { 1, 3, 5 };
            int firstNumber = numbers.First(x => x % 2 == 0); // will return exception
            int firstNumberordefault = numbers.FirstOrDefault(x => x % 2 == 0); // will return 0

        }
    }
}


