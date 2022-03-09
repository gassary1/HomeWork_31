using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_31
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
