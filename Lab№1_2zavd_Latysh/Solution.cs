using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2zavd_Latysh
{
    class Solution
    {
        public delegate int[] MyDelegate(int[] array, int k);
        public int[] Method1(int[] array, int k)
        {
            IEnumerable<int> query = array.Where(num => num % k == 0);
            Console.WriteLine($"Масив з елементами, кратними {k}: [{string.Join(", ", query)}]");
            return query.ToArray();
        }
        public int[] Method2(int[] array, int k)
        {
            string text = "fgdfghdfg";
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % k == 0)
                    count++;
            }
            int[] newArray = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % k == 0)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }
            Console.WriteLine($"Масив з елементами, кратними {k}: [{string.Join(", ", newArray)}]");
            return newArray;
        }
    }
}
