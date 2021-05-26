using System;
using System.Collections.Generic;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            Predicate<int>[] pr = { x => x % 3 == 0 || x % 7 == 0 };
            foreach (var item in MySelect(arr,pr[0]))
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }

        static int[] MySelect(int[] arr, Predicate<int> pr)
        {
            List<int> selected = new List<int>();

            foreach (var item in arr)
            {
                if (pr(item))
                {
                    selected.Add(item);
                }
            }
            return selected.ToArray();
        }
    }
}
