using System;
using System.Collections.Generic;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    class Seller
    {
        private IMessage _simpleMessage;
        private IMessage _alertMessage;
        private string _name;
        private int _gold;
        private List<Item> _items;

        public string Name => _name;
        public int Gold => _gold;

        public Seller(string name, int gold)
        {
            _name = name;
            _gold = gold;
            _items = new List<Item>();
            _items.Add(new Item("11", 2, 10));
            _items.Add(new Item("14", 2, 15));
            _items.Add(new Item("16", 5, 4));

        }
        public void SellItemToPlayer(Player player, int currentPosition)
        {
            Item salledItem;

            if (TryGetProduct(currentPosition, out Item item) && player.Gold>0 && player.Gold>item.Price)
            {
                salledItem = (Item)item.Clone();
                salledItem.Amount = 1;

                _gold += salledItem.Price;
                _items[currentPosition-1].Amount--;

                player.AddItem(salledItem);

                if (_items[currentPosition-1].Amount==0)
                {
                    _items.Remove(item);
                }
                _simpleMessage = new NormalDecorator(new SimpleMessage("Продажа прошла успешно"));
                _simpleMessage.PrintMessage();
            }
            else
            {
                _alertMessage = new ErrorDecorator(new AlertMessage("Продажа не прошла"));
                _alertMessage.PrintMessage();
            }
        }

        public void ShowItems()
        {
            Console.WriteLine($"Лавка продавца {Name}. Баланс - {Gold}");

            foreach (var item in _items)
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
