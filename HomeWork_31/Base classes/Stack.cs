using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_31.Base_classes
{
    class Stack
    {
        private Item _item;
        private int _amount;

        public int Amount => _amount;
        public Item Item => _item;

        public Stack(Item item, int amount)
        {
            _item = item;
            _amount = amount;
        }

        public void AddItemAmountByOne()
        {
            _amount += 1;
        }

        public void DecreaseStackAmountByOne()
        {
            _amount -= 1;
        }

        public void ShowStackInfo()
        {
            Console.WriteLine($"Название: {_item.Name,15} Количество: {Amount, 5} Цена: {_item.Price,2} золотых");
        }
    }
}
