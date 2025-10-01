using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice playerDice = new Dice();
            //Player charictor = new Player(Console.ReadLine());

            Slime slime = new Slime();
            //Console.WriteLine(item.ToString());
            //slime.Monsterdeath();
            bool a = int.TryParse(Console.ReadLine(), out int b);
            Inventory inventory = new Inventory();
            inventory.ItemAdd(new Item("강철 방패", " ", 18, 0, false, 3500, ItemType.Shield, false, false));
            inventory.ItemAdd(new Item("강철 검", " ", 8, 12, false, 4700, ItemType.Sword, false, false));
            inventory.ItemAdd(new Item("강철 장검", " ", 25, 0, false, 7000, ItemType.Sword, false, false));
            inventory.ItemAdd(new Item("강철 갑옷", " ", 0, 12, false, 3100, ItemType.Armor, false, false));
            inventory.ItemRemove(b);
            Console.WriteLine();
           

            inventory.itemShow();

        }
    }
}
