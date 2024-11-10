using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_5_generalized_interface
{
    public class ListStorage<T> : IStorage<T>
    {
        private List<T> _items;

        public ListStorage()
        {
            _items = new List<T>(); 
        }

        // Реализация метода Add
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");
            }
            _items.Add(item); 
        }

        // Реализация метода Get
        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс находится за пределами диапазона");
            }
            return _items[index]; 
        }
    }
}
