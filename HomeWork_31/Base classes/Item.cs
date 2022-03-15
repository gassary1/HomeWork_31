using System;
using System.Collections.Generic;

namespace HomeWork_31.Base_classes
{
    class Item
    {
        private string _name;
        private int _amount;
        private int _price;

        public string Name => _name;
        public int Amount => _amount;
        public int Price => _price;

        public Item(string name, int amount, int price)
        {
            _name = name;
            _amount = amount;
            _price = price;
        }

        public Item() : this("", 0, 0) { }

        public void SetOneToItemAmount()
        {
            _amount = 1;
        }

        public void AddItemAmountByOne()
        {
            _amount += 1;
        }

        public void DecreaseItemAmountByOne()
        {
            _amount -= 1;
        }

        public void ShowItemInfo()
        {
            Console.WriteLine($"Название: {Name,15} Количество: {Amount,2} Цена: {Price,2} золотых");
        }

        public object Clone()
        {
            return new Item(_name, _amount, _price);
        }
    }
}