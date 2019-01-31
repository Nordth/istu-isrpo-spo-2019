using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issues
{
    class Program
    {
        public static void ReadQuery(List<int> query)
        {
            int q;
            string str;
            bool cont = true;
            while (cont)
            {
                str = Console.ReadLine();
                if (!String.IsNullOrEmpty(str))
                {
                    if (Int32.TryParse(str, out q))
                    {
                        query.Add(q);
                    }
                    else
                    {
                        Console.WriteLine("Enter the number!");
                    }
                }
                else
                    cont = false;
            }                
        }

        public static List<int> SortQuery(List<int> query)
        {
            int k1, k2;
            for (int i = 0; i < query.LongCount() - 1; i++)
            {
                for (int j = i; j < query.LongCount() - 1; j++)
                {
                    if (query.ElementAt(i) > query.ElementAt(j + 1))
                    {
                        k1 = query.ElementAt(i);
                        k2 = query.ElementAt(j + 1);
                        query.RemoveAt(i);
                        query.Insert(i, k2);
                        query.RemoveAt(j + 1);
                        query.Insert(j + 1, k1);
                    }
                }
            }
            return query;
        }

        public static List<int> OnlyUnique(List<int> query)
        {
            for (int i = 0; i < query.LongCount() - 1; i++)
            {
                if (query.ElementAt(i) == query.ElementAt(i + 1))
                {
                    query.RemoveAt(i);
                    i--;
                }
            }
            return query;
        }

        public static void FindMaxAndMin(List<int> query)
        {
            int max = Int32.MinValue, min = Int32.MaxValue;
            for (int i = 0; i < query.LongCount(); i++)
            {
                if (query.ElementAt(i) > max)
                {
                    max = query.ElementAt(i);
                }
                if (query.ElementAt(i) < min)
                {
                    min = query.ElementAt(i);
                }
            }
            Console.Write("Minimum = " + min + "\n\r" + "Maximum = " + max + "\n\r");
        }

        public static void WriteQuery(List<int> query)
        {
            foreach(int el in query)
            {
                Console.Write(el + " ");
            }
        }

        static void Main(string[] args)
        {
            List<int> query = new List<int>();
            ReadQuery(query);  //Read
            SortQuery(query);  //Sort
            OnlyUnique(query);  //Delete ununique
            FindMaxAndMin(query);  //Find and write min and max
            WriteQuery(query);  //Write query
            Console.ReadKey();
        }
    }
}
