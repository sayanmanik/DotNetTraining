using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class ProductCollection : CollectionBase
    {
        public void Add(Product i)
        {
            List.Add(i);
        }

        public void Remove(Product i)
        {
            List.Remove(i);
        }

        public void Insert(int index, Product i)
        {
            List.Insert(index,i);
        }

        public void RemoveByIndex(int index)
        {
            List.RemoveAt(index);
        }
    }
}
