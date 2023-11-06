using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Repository<T>
    {
        private List<T> items = new List<T>();

        public delegate bool Criteria<T>(T item);

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> Find(Func<T, bool> criteria)
        {
            return items.Where(criteria).ToList();
        }
    }
}
