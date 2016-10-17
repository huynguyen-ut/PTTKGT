using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Element<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        Element<T> next;

        internal Element<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public Element(T data)
        {
            this.data = data;

        }
    }
}