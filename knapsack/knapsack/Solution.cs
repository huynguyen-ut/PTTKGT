using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Solution
    {
        private List<Object> obj;
        private Bag bag;
        private int Vmax;
        private byte mode;
        public Solution(List<Object> obj,Bag bag) {
            this.obj = obj;
            this.bag = bag;
            this.Vmax = 0;
            this.mode = 0;
        }
        public void PrintSolution() {
            foreach (Object o in this.bag.Obj) {
                if(o.Status==1)
                Console.WriteLine(o.Name+" "+o.W+" "+o.V);
            }
            Console.WriteLine("////////////////////////////");
        }
        public void run() {
            switch (mode) {
                case 0: retry(0);
                        break;
        }
           
        }
        private void retry(int i) {
            for (int j = 0; j <= 1; j++) {
                obj[i].Status = j;
                if (obj[i].Status == 1)
                    this.bag.addObject(obj[i]);
                else
                    this.bag.removeObject(obj[i]);
                if (i == (obj.Count - 1)){
                if(this.bag.Weight>this.bag.TotalWeight()&&this.bag.TotalValue()>Vmax)
                {                      
                        PrintSolution();
                }
              }
                else retry(i + 1);
            }
        }
    }
}
