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
            Item item = new Item("강철 방패", " ",8,12,false,3500,ItemType.Shield,false,false);
            Console.WriteLine(item.ToString());
            //slime.Monsterdeath();
           
        }
    }
}
