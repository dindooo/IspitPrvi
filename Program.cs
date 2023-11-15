using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitPrvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Upisite jednu recenicu");
            string niz = Console.ReadLine();
            Console.WriteLine(niz.Replace(" ", "_"));
            Console.ReadKey();

        }
    }
}
