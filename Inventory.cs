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
        static public List<Item> itemInventory;
        static public List<Potion> potionInventory;
        public Inventory()
        {
            itemInventory = new List<Item>();
            potionInventory = new List<Potion>();
        }
        static public void ItemAdd(Item item) //아이템 추가
        {
            itemInventory.Add(item);
        }
        public void ItemRemove(int a) //아이템 제거 및 확인내용
        {
            Console.Clear();
            itemInventory.RemoveAt(a);
            Console.WriteLine($"아이템 {a + 1}번을 삭제했습니다.");
        }
        static public void ItemShow() //보유중인 아이템 출력
        {
                Console.WriteLine("----------------------------------");
            for(int i = 0; i<itemInventory.Count; i++)
            {
                Item item = itemInventory[i];
                Console.Write($"[{i + 1}] ");
                if (itemInventory[i].isEq == true)
                {
                    Console.Write("[E] ");
                }
                item.Equipments();
            }
                Console.WriteLine("----------------------------------");
        }
        static public void PotionAdd(Potion potion) //아이템 추가
        {
            potionInventory.Add(potion);

        }
        public void PotionRemove(int a) //아이템 제거 및 확인내용
        {
            Console.Clear();
            potionInventory.RemoveAt(a);
            Console.WriteLine($"포션 {a + 1}번을 삭제했습니다.");
        }
        static public void PotionShow() //보유중인 아이템 출력
        {
            Console.WriteLine("----------------------------------");
            foreach(var i in potionInventory)
            {
                i.Potions();
            }
            Console.WriteLine("----------------------------------");
        }
        static public void ShowInventory()
        {
            ItemShow();
            PotionShow();
        }
    }
  
}
