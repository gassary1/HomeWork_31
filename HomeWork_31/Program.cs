using System;
using System.Collections.Generic;
using HomeWork_31.Base_classes;

namespace HomeWork_31
{
    class Program
    {
        static void Main(string[] Args)
        {
            Player player = new Player("xxx", 231);
            Seller seller = new Seller("qqq", 1111);

            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();


            seller.SellItemToPlayer(player, 3);

            Console.WriteLine();
            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();
            Console.WriteLine();

            seller.SellItemToPlayer(player, 3);

            Console.WriteLine();
            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();
            Console.WriteLine();

            seller.SellItemToPlayer(player, 3);

            Console.WriteLine();
            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();
            Console.WriteLine();

            seller.SellItemToPlayer(player, 3);

            Console.WriteLine();
            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();
            Console.WriteLine();

            seller.SellItemToPlayer(player, 3);

            Console.WriteLine();
            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();
            Console.WriteLine();

            seller.SellItemToPlayer(player, 1);

            Console.WriteLine();
            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();
            Console.WriteLine();

            seller.SellItemToPlayer(player, 1);

            Console.WriteLine();
            seller.ShowItems();
            Console.WriteLine();
            player.ShowInventory();
            Console.WriteLine();

        }
    }
}