using System;
using System.Collections.Generic;
using HomeWork_31.Base_classes;

namespace HomeWork_31
{
    class Program
    {
        static void Main(string[] Args)
        {
            bool isActive = true;
            int itemPosition;
            ConsoleKey userOption;
            Person player = new Player("Player", 100);
            Saller seller = new Saller("Saller", 1111);

            while (isActive)
            {
                player.ShowItems();
                Console.WriteLine();
                PrintMenu();
                Console.Write("\nВыберите действие: ");
                userOption = Console.ReadKey().Key;

                Console.Clear();
                if (userOption == ConsoleKey.D1)
                {
                    seller.ShowItems();
                }
                else if (userOption == ConsoleKey.D2)
                {
                    seller.ShowItems();

                    Console.Write("\nВыберите номер предмета: ");
                    itemPosition = GetNumber();

                    seller.SellItemToPlayer((Player)player, itemPosition);
                }
                else if (userOption == ConsoleKey.D3)
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine("Неизвестный выбор");
                }
            }

            seller.ShowItems();
            Console.WriteLine();
            player.ShowItems();
            
        }

        static void PrintMenu()
        {
            Console.WriteLine("1 - Посмотреть ассортимент товаров\n2 - Купить предмет\n3 - Выход");
        }

        static int GetNumber()
        {
            bool isActive = true;
            int result = 0;

            while (isActive)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out result))
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            return result;
        }
    }
}