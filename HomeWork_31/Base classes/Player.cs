using System;
using System.Collections.Generic;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    class Player : Person
    {
        public Player(string name, int gold) : base(name, gold) { }

        private void AddItem(Item item)
        {

        }

        public override void ShowItems()
        {
            foreach(var item in _items)
            {
                item.ShowItemInfo();
            }
        }

        public override void SellItem()
        {
            throw new NotImplementedException();
        }
    }
}
