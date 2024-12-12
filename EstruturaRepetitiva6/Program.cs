using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++) {
                    if (n % i == 0) {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}