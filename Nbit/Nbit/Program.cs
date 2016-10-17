using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbit
{
    class Program
    {
        static void Main(string[] args)
        {
            NBit nbit = new NBit(4);
            nbit.Try(0);
            Console.ReadKey();
        }
    }
}
