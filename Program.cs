using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitCetvrti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite prvu rijec");
            string prvi = Console.ReadLine();
            Console.WriteLine("Upisite drugu rijec");
            string drugi = Console.ReadLine();
            char[] abeceda = prvi.ToCharArray();
            Array.Sort(abeceda);
            Console.WriteLine(abeceda);
            char[] abeceda2 = drugi.ToCharArray();
            Array.Sort(abeceda2);
            Console.WriteLine(abeceda2);

            Console.ReadKey();
       

        }
    }
}
