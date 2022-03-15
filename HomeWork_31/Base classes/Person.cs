using System.Collections.Generic;

namespace HomeWork_31.Base_classes
{
    abstract class Person
    {
        private protected string _name;
        private protected int _gold;
        private protected List<Item> _inventory;

        public string Name => _name;
        public int Gold { get { return _gold; } protected set { _gold = value; } }

        public Person(string name, int gold)
        {
            _name = name;
            _gold = gold;
        }

        public virtual void SellItemToPlayer(Player player, int currentPosition) { }

        abstract public void ShowItems();
    }
}