using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insert the first range: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("insert the second range: ");
            int second = int.Parse(Console.ReadLine());

            for(int x=first; x<=second;x++)
            {
                if(x % 5 ==0)
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
