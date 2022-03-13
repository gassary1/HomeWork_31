using System;
using System.Collections.Generic;
using System.Linq;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    class Player
    {
        private string _name;
        private int _gold;
        private List<Item> _inventory;

        public string Name => _name;
        public int Gold => _gold;

        public Player(string name, int gold)
        {
            _name = name;
            _gold = gold;
            _inventory = new List<Item>();
        }

        public void AddItem(Item item)
        {
            if (!CheckItem(item))
            {
                _inventory.Add(item);
            }
            else
            {

                Console.WriteLine(">");
            }

            for (int i = 1; i < _inventory.Count; i++)
            {
                if (_inventory[i].Name == _inventory[i - 1].Name)
                {
                    _inventory[i] = _inventory[i - 1];

                    if (_inventory[i] == _inventory[i - 1])
                    {
                        _inventory[i].Amount += 1;
                        _inventory.Remove(_inventory[i - 1]);
                    }
                }
            }

            _gold -= item.Price;
        }

        public void ShowInventory()
        {
            Console.WriteLine($"Инвентарь игрока {Name}. Баланс - {Gold}");

            foreach (var item in _inventory)
            {
                item.ShowItemInfo();
            }
        }

        private bool CheckItem(Item item)
        {
            return _inventory.Contains(item);
        }
    }
}
