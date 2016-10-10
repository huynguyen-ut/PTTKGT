using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Solution
    {
        List<Object> obj;
        Bag bag;
        int Vmax;
        
        public Solution(List<Object> obj,Bag bag) {
            this.obj = obj;
            this.bag = bag;
            Vmax = 0;
        }
        public void PrintSolution() {
            foreach (Object o in this.bag.Obj) {
                if(o.Status==1)
                Console.WriteLine(o.Name+" "+o.W+" "+o.V);
            }
            Console.WriteLine("////////////////////////////");
        }
        public void run() {
            retry(0);
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

                       // foreach (Object ob in this.obj)
                         //   if (obj[i].Status == 1)
                           //     this.bag.addObject(obj[i]);
                        PrintSolution();
                }
              }
                else retry(i + 1);
            }
        }
    }
}
