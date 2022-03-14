using System.Collections.Generic;

namespace HomeWork_31.Base_classes
{
    abstract class Person
    {
        protected string _name;
        protected int _gold;
        protected List<Item> _inventory;

        public string Name => _name;
        public int Gold => _gold;

        public Person(string name, int gold)
        {
            _name = name;
            _gold = gold;
        }

        abstract public void ShowItems();
    }
}