using System;
using System.Collections.Generic;

namespace HomeWork_31.Base_classes
{
    class Item
    {
        private string _name;
        private int _price;

        public string Name => _name;
        public int Price => _price;

        public Item(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public Item() : this("", 0) { }

        public void ShowItemInfo()
        {
            Console.WriteLine($"Название: {Name,15} Цена: {Price,2} золотых");
        }
    }
}