using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', i*2), new string('-', n-2*i));
            }
            for (int i = n; i > 0; i-=2)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', i), new string('.', 2*n+1-2*i));
            }
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{1}#{0}#{1}", new string('.', 2 * n + 1-2*i), new string('-', i));
            }
            
        }
    }
}
