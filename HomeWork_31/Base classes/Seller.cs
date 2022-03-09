using System;
using System.Collections.Generic;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    class Seller : Person
    {
        private Player _player;

        public Seller(string name, int gold) : base(name, gold)
        {

        }
        public void SellItemToPlayer(Player player)
        {
            if(TryGetProduct(out Item item))
            {
                item.Amount--;
            }
        }

        public override void ShowItems()
        {
            Console.WriteLine($"Лавка продавца - {_name}");

            foreach (Item item in _items)
            {
                item.ShowItemInfo();
            }
        }

        private bool TryGetProduct(int currentPosition, out Item item)
        {
            int itemPosition = currentPosition - 1;
            item = null;

            if (_items[itemPosition] == null)
            {
                return false;
            }

            item = _items[itemPosition];
            return true;
        }
    }
}
