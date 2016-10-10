using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Bag
    {
        int id;
        List<Object> obj;

        internal List<Object> Obj
        {
            get { return obj; }
            set { obj = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int W;

        public int Weight
        {
            get { return W; }
            set { W = value; }
        }
        public int TotalWeight() {
            int sum = 0;
           foreach(Object o in this.obj)
               if (o.Status==1) {
                   sum += o.W;
               }
           return sum;
        }
        public int TotalValue()
        {
            int sum = 0;
            foreach (Object o in this.obj)
                if (o.Status == 1)
                {
                    sum += o.V;
                }
            return sum;
        }
        public Bag(int W) {
            this.W = W;
            this.obj = new List<Object>();
        }
        public void addObject(Object o) {
            this.obj.Add(o);
           
        }
        public void removeObject(Object o) {
            
            foreach (Object b in Obj) {
                if (o.Id == b.Id)
                {
                    this.obj.Remove(o);
                    break;
                }
            }
        }
    }
}
