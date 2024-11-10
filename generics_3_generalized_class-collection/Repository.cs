using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_3_generalized_class_collection
{
    internal class Repository<T> where T : class
    {
        private List<T> _items;

        public Repository()
        {
            _items = new List<T>(); // Инициализация внутреннего списка
        }

        // Метод для добавления элемента в репозиторий
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Элемент не может быть null");
            }
            _items.Add(item);
        }

        // Метод для получения элемента по индексу
        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс находится за пределами диапазона");
            }
            return _items[index];
        }

        // Метод для получения всех элементов
        public IEnumerable<T> GetAll()
        {
            return _items; 
        }
    }
}
