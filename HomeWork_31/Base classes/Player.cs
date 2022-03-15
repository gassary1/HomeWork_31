using System;
using System.Collections.Generic;
using System.Linq;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    class Player : Person
    {
        public Player(string name, int gold) : base(name, gold)
        {
            _inventory = new List<Stack>();
        }

        public void AddItem(Item item)
        {
            _inventory.Add(new Stack(item,1));

            Gold -= item.Price;

            for (int i = 1; i < _inventory.Count; i++)
            {
                if (_inventory[i].Item.Name == _inventory[i - 1].Item.Name)
                {
                    _inventory[i] = _inventory[i - 1];

                    if (_inventory[i] == _inventory[i - 1])
                    {
                        _inventory[i].AddItemAmountByOne();
                        _inventory.Remove(_inventory[i - 1]);
                    }
                }
            }
        }

        public override void ShowItems()
        {
            int position = 1;

            Console.WriteLine($"Инвентарь игрока {Name}. Баланс - {Gold}");

            foreach (var item in _inventory)
            {
                Console.Write($"{position++})");
                item.ShowStackInfo();
            }
        }
    }
}