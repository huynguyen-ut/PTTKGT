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
        private Bag solution;

        public byte Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
            }
        }

        public Solution(List<Object> obj,Bag bag) {
            this.obj = obj;
            this.bag = bag;
            this.Vmax = 0;
            this.Mode = 0;
            solution = new Bag(27);
        }
        public void PrintSolution() {
            foreach (Object o in this.solution.Obj) {
                if(o.Status==1)
                Console.WriteLine(o.Name+" "+o.W+" "+o.V);
            }
            Console.WriteLine("////////////////////////////");
        }
        public void run() {
            switch (Mode) {
                case 0: retry(0);
                        break;
                case 1: this.GreedyAlgorithm();
                    break;
        }
           
        }
        private void GreedyAlgorithm() {
            obj.Sort();
            bag.Obj.Clear();
            foreach (Object o in this.obj)
                o.Status = 0;
            foreach (Object o in this.obj)
                if (this.bag.TotalWeight()+o.W<=this.bag.Weight) {
                    this.bag.addObject(o);
                    o.Status = 1;
                }
            this.solution.Obj.Clear();
            foreach (Object o in bag.Obj)
            {
                this.solution.addObject(o.ShallowCopy());
            }

        }
        private void CopySolution() {
            if(this.solution.Obj.Count>0)
            this.solution.Obj.Clear();
            foreach (Object o in bag.Obj) {
                this.solution.addObject(o.ShallowCopy());
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
                        Vmax = this.bag.TotalValue();
                        this.CopySolution();
                }
              }
                else retry(i + 1);
            }
        }
    }
}
