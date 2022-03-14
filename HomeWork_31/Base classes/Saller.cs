using System;
using System.Collections.Generic;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    class Saller:Person
    {
        private IMessage _simpleMessage;
        private IMessage _alertMessage;

        public Saller(string name, int gold):base(name,gold)
        {
            _inventory = new List<Item>();
            _inventory.Add(new Item("Клинок", 2, 40));
            _inventory.Add(new Item("Лечебное зелье", 5, 10));
            _inventory.Add(new Item("Зелье маны", 5, 18));
            _inventory.Add(new Item("Амулет", 4, 20));

        }
        public void SellItemToPlayer(Player player, int currentPosition)
        {
            int itemPosition = currentPosition - 1;
            Item salledItem;

            if (TryGetProduct(currentPosition, out Item item) && player.Gold > 0 && player.Gold > item.Price)
            {
                salledItem = (Item)item.Clone();
                salledItem.Amount = 1;

                _gold += salledItem.Price;
                _inventory[itemPosition].Amount--;

                player.AddItem(salledItem);

                if (_inventory[itemPosition].Amount==0)
                {
                    _inventory.Remove(item);
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

        public override void ShowItems()
        {
            int position = 1;

            Console.WriteLine($"Лавка продавца {Name}. Баланс - {Gold}");

            foreach (var item in _inventory)
            {
                Console.Write($"{position++})");
                item.ShowItemInfo();
            }
        }

        private bool TryGetProduct(int currentPosition, out Item item)
        {
            int itemPosition = currentPosition - 1;
            item = null;

            if (currentPosition > _inventory.Count || _inventory[itemPosition] == null)
            {
                return false;
            }

            item = _inventory[itemPosition];
            return true;
        }
    }
}
