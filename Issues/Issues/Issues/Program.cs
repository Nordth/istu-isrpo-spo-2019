using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issues
{
    class Program
    {
        public static List<int> OnlyUnique(List<int> sorted)
        {
            for (int i = 0; i <	 sorted.LongCount() - 1; i++)
            {
                if (sorted.ElementAt(i) == sorted.ElementAt(i + 1))
                {
                    sorted.RemoveAt(i);
                    i--;
                }
            }
            return sorted;
        }
		public static List<int> stroka()
        {
            List<int> sorted = new List<int>();
            int n;
            string s = Console.ReadLine();
            while (s != "")
            {
                if (Int32.TryParse(s, out n) == true)
                {
                    sorted.Add(n);
                    s = Console.ReadLine();
                }
            }
            return sorted;
        }
        static void minmax(List<int> sorted)
        {
            int minnum = sorted[0];
            int maxnum = sorted[0];
            for (int i = 0; i <= sorted.Count - 1; i++)
            {
                if (sorted[i] < minnum)
                {
                    minnum = sorted.ElementAt(i);
                }
                if (sorted[i] > maxnum)
                {
                    maxnum = sorted.ElementAt(i);
                }
            }
            Console.WriteLine("min = " + minnum);
            Console.WriteLine("max = " + maxnum);
        }

        static void Main(string[] args)
        {
        }
    }
}
