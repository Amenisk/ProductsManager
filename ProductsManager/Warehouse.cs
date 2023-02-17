using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManager
{
    public class Warehouse
    {
        private Product[] products = new Product[] { new Product("Сыр", "Магнит", 150), new Product("Хлеб", "Пятёрочка", 50), 
            new Product("Молоко", "Верный", 40), new Product("Гречка", "Магнит", 100), new Product("Рис", "Верный", 120), new Product("Яблоки", "Пятёрочка", 80), 
            new Product("Картошка", "Магнит", 30), new Product("Огурцы", "Пятёрочка", 190), new Product("Колбаса", "Магнит", 200), new Product("Шоколад", "Верный", 60)};

        public Product GetProductByIndex(int index)
        {
            if(index < products.Length && index >= 0)
            {
                return products[index];
            }
            Console.WriteLine("Товара с таким индексом не существует");
            return null;
        }



    }
}
