using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2zavd_Latysh
{
    class Program
    {
        public bool isAliquot(int x, int y)
        {
            return x % y == 0;
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Введіть число, якому елементи масиву повинні бути кратні:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Оберіть яким способом виконати задачу: \n 1. З Метод Where класу Enumerable\n 2. Власна реалізація,");
            int x = int.Parse(Console.ReadLine());
            Solution.MyDelegate myDelegate = null;
            switch (x)
            {
                case 1: myDelegate = new Solution.MyDelegate(solution.Method1);
                    break;
                case 2: myDelegate = new Solution.MyDelegate(solution.Method2);
                    break;
            }
            myDelegate(array, k);
        }
    }
}
