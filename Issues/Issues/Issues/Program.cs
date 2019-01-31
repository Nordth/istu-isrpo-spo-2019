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
            for (int i = 0; i < sorted.LongCount() - 1; i++)
            {
                if (sorted.ElementAt(i) == sorted.ElementAt(i + 1))
                {
                    sorted.RemoveAt(i);
                    i--;
                }
            }
            return sorted;
        }

        static void Main(string[] args)
        {
        }
    }
}
