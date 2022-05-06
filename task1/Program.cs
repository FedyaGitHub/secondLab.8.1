using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new DelClass().ReturnNum();
            Console.ReadKey();
        }
    }
    class DelClass
    {
        public delegate double MyDelegate(double a, double b, double c);
        public void ReturnNum()
        {
            double someResult = 0;
            MyDelegate myDelegate = delegate (double a, double b, double c)
            {
                someResult = (a + b + c) / 3;
                return someResult;
            };
            someResult = myDelegate(10, 26.5, 13);
            Console.WriteLine($"Arithmetic mean of arguments = {someResult}");
        }
    }
}
