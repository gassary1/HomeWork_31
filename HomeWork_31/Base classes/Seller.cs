using System;
using System.Collections.Generic;
using HomeWork_31.Message_decorator;

namespace HomeWork_31.Base_classes
{
    class Seller : Person
    {
        private IMessage _simpleMessage;
        private IMessage _alertMessage;

        public Seller(string name, int gold) : base(name, gold)
        {
            _inventory = new List<Stack>();
            _inventory.Add(new Stack(new Item("Клинок", 40), 2));
            _inventory.Add(new Stack(new Item("Лечебное зелье", 10), 5));
            _inventory.Add(new Stack(new Item("Зелье маны", 18), 5));
            _inventory.Add(new Stack(new Item("Амулет", 20), 4));
        }

        public override void SellItemToPlayer(Player player, int currentPosition)
        {
            int itemPosition = currentPosition - 1;

            if (TryGetProduct(currentPosition, out Item item) && player.Gold > 0 && player.Gold > item.Price)
            {
                Gold += item.Price;
                _inventory[itemPosition].DecreaseStackAmountByOne();

                player.AddItem(item);

                if (_inventory[itemPosition].Amount == 0)
                {
                    _inventory.Remove(_inventory[itemPosition]);
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
                item.ShowStackInfo();
            }
        }

        private bool TryGetProduct(int currentPosition, out Item item)
        {
            int itemPosition = currentPosition - 1;
            item = null;

            if (currentPosition > _inventory.Count || _inventory[itemPosition].Item == null)
            {
                return false;
            }

            item = _inventory[itemPosition].Item;
            return true;
        }
    }
}