using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Object E = new Object("E", 3, 4);

            Object F = new Object("F", 15, 30);
            Object G = new Object("G", 10, 25);
            Object H = new Object("H", 1, 25);
            Object U = new Object("U", 2, 25);
            Object I = new Object("I", 3, 4);
            List<Object> listOject = new List<Object>();
            listOject.Add(A);
            listOject.Add(B);
            listOject.Add(C);
            listOject.Add(D);
            listOject.Add(E);

            listOject.Add(F);
            listOject.Add(G);
            listOject.Add(H);
            listOject.Add(U);
            listOject.Add(I);

            listOject.Add(F);
            listOject.Add(G);
            listOject.Add(H);
            listOject.Add(U);
            listOject.Add(I);
            
            Bag bag = new Bag(27);
            Solution solution = new Solution(listOject,bag);
            Stopwatch st1 = new Stopwatch();
            st1.Start();
            solution.run();
            solution.PrintSolution();
            st1.Stop();
            Console.WriteLine("{0} Seconds", st1.Elapsed.ToString());

            Stopwatch st2 = new Stopwatch();
            st2.Start();
            solution.Mode = 1;
            solution.run();
            solution.PrintSolution();
            st2.Stop();
            Console.WriteLine("{0} Seconds", st2.Elapsed.ToString());
            Console.ReadKey();

        }
    }
}
