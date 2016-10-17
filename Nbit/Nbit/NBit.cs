using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbit
{
    class NBit
    {
        private int []Bits;
        private int nBit;
        public NBit(int n) {
            Bits = new int[n];
            nBit = n;
        }
        public void Try(int i) {
            for (int j = 0; j <= 1; j++) {
                Bits[i] = j;
                if (i == nBit - 1)
                {
                    this.PrintSolution();
                }
                else
                    Try(i + 1);
            }
        }
        public void PrintSolution() {
            for (int i = 0; i < nBit; i++) {
                Console.Write(Bits[i]);
            }
            Console.WriteLine("");
        }
    }
}
