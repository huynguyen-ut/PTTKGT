using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unfairness
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inc = {10,20,30,100,200,300,1000};
            ExhaustedSearh ex = new ExhaustedSearh(inc, 3);
            ex.Solve();
            Console.ReadKey();
        }
    }
}
