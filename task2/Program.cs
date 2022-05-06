using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        public delegate int FirstDel();
        public delegate int SecondDel(FirstDel [] firstDels);
        public static Random random = new Random();
        public static int RandomNums() => random.Next(1, 5);
        static void Main(string[] args)
        {
            FirstDel[] deleg1s = new FirstDel[10];

            int[] arr = new int[deleg1s.Length];

            for (int i = 0; i < deleg1s.Length; i++)
            {
               
                deleg1s[i] = RandomNums;
            }
            Console.WriteLine("Array output...");
            Console.WriteLine();
            for (int i = 0; i < deleg1s.Length; i++)
            {
                
                arr[i] = deleg1s[i]();
                Console.WriteLine(arr[i]);
            }
            SecondDel deleg2 = delegate (FirstDel[] massive)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                }
                Console.WriteLine($"Sum = {sum}");

                return sum / (massive.Length);
            };
            Console.WriteLine();
            Console.WriteLine($"Среднее арифметическое чисел массива = {deleg2(deleg1s)}");
        }
    }
}
