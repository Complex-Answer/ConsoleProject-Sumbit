using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{

    class Inventory
    {
        public List<Item> itemInventory = new List<Item>();

        public void ItemAdd(Item item)
        {
            itemInventory.Add(item);
        }
        public void ItemRemove(int a)
        {
            Console.Clear();
            Console.WriteLine($"아이템 {a}번을 삭제했습니다.");
            itemInventory.RemoveAt(a);
        }
        public void itemShow()
        {

            foreach (var i in itemInventory)
            {
                Console.WriteLine(i);
            }

        }
    }
}
