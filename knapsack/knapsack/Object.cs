using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Object : IComparable
    {
        private static int id=0;

        public int Id
        {
            get { return id; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int status;
        public Object ShallowCopy()
        {
            return (Object)this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            if (this.v > ((Object)obj).v)
                return -1;
            else return 1;
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private int w;

        public int W
        {
            get { return w; }
            set { w = value; }
        }
        private int v;

        public int V
        {
            get { return v; }
            set { v = value; }
        }
        public Object(string name,int w, int v) {
            this.name = name;
            this.w = w;
            this.v = v;
            id++;
        }
    }
}
