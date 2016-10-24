using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unfairness
{
    class ExhaustedSearh
    {
        private int[] K;
        private int[] N;

       

        public ExhaustedSearh(int[] arr, int k) {
            N = arr;
            K = new int[k];

        }
       
        public void Try(int i) {
            for (int index =0; index < N.Count<int>(); index++) {
                if ( i == 0)
                {
                    K[i] = N[index];
                    Try(i + 1);
                }
                else {
                    if (N[index] > K[i - 1]) {
                        K[i] = N[index];
                        if (i == K.Count<int>() - 1)//
                        {
                            this.PrintSolution();
                        }
                        else Try(i + 1);
                    }

                }
               

            }
        }
        public void Solve() {
            this.Try(0);
        }
        public void PrintSolution() {
            for (int i = 0; i < K.Count<int>(); i++)
                Console.Write(K[i]+" ");
            Console.WriteLine();
        }

    }
}
