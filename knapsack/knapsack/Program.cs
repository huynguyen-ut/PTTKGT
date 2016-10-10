using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            Object A = new Object("A",15,30);
            Object B = new Object("B", 10, 25);
            Object C = new Object("C", 1, 25);
            Object D = new Object("D", 2, 25);
            Object E = new Object("E", 1, 4);
            List<Object> listOject = new List<Object>();
            listOject.Add(A);
            listOject.Add(B);
            listOject.Add(C);
            listOject.Add(D);
            listOject.Add(E);

            Bag bag = new Bag(27);
            Solution solution = new Solution(listOject,bag);
            solution.run();
            Console.ReadKey();

        }
    }
}
