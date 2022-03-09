using System;
using System.Collections.Generic;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    abstract class Person
    {
        protected string _name;
        protected int _gold;
        protected List<Item> _items;

        protected string Name => _name;
        protected int Gold => _gold;

        public Person(string name, int gold)
        {
            _name = name;
            _gold = gold;
        }

        public abstract void ShowItems();
        public abstract void SellItem();
    }
}
