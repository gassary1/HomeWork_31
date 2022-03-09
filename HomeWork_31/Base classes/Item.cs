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
        public int Amount { get { return _amount; } private set { _amount = value; } }
        public int Price => _price;

        public Item(string name, int amount, int price)
        {
            _name = name;
            _amount = amount;
            _price = price;
        }

        public void ShowItemInfo()
        {
            Console.WriteLine($"{Name,10} {Amount,5} {Price,5}");
        }
    }
}
