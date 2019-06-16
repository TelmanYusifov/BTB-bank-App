using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTB_Expense_system.Database
{
    public class DbSet<T> where T:class
    {
        private readonly List<T> _items;
        public DbSet()
        {
            _items = new List<T>();
        }
        public IEnumerable<T> GetAsEnumerable()
        {
            foreach(T item in _items)
            {
                yield return item;
            }
        }
        public IEnumerable<T> GetAll()
        {
            return _items;
        }
        public void Add(T Item)
        {
            _items.Add(Item);
        }
        public bool Remove (T Item)
        {
            return _items.Remove(Item);
        }
        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}
