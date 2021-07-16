using System.Threading;
using System;

namespace dotnet0524
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program pro = new Program();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(pro.myFunction() + Convert.ToString(i));
            }
        }

        string myFunction()
        {
            return "MinGyu";
        }
    }
}
