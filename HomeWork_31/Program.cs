using System;
using System.Collections.Generic;

namespace HomeWork_31
{
    class Program
    {
        static void Main(string[] Args)
        {

        }
    }

    class Player:Person
    {
        public Player(string name, int gold) : base(name, gold)
        {

        }
    }

    class Seller:Person
    {
        public Seller(string name, int gold) : base(name, gold)
        {

        }
        public bool SellProduct()
        {

        }

        private bool GetProduct(out Item product)
        {

        }
    }

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

        public void ShowItemInfo()
        {
            Console.WriteLine($"{Name,10} {Amount,5} {Price,5}");
        }
    }

    abstract class Person
    {
        protected string _name;
        protected int _gold;
        protected List<Item> _items;

        public string Name => _name;
        public int Gold => _gold;

        public Person(string name, int gold)
        {
            _name = name;
            _gold = gold;
        }

        protected void ShowItems()
        {
            foreach (Item item in _items)
            {
                item.ShowItemInfo();
            }
        }
    }
}