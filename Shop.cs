using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    class Shop
    {
        List<Item> shopItems = new List<Item>();
        List<Potion> shopPotion = new List<Potion>();
        public Shop()
        {

        }
        public void ShopSetting()
        {
            shopItems.Add(new Sword("목검", 10, 800, ItemType.Sword));
            shopItems.Add(new Shiled("나무 방패", 5, 8, 1200, ItemType.Shield));
            shopItems.Add(new Armor("천 갑옷", 5, 30, 700, ItemType.Armor));
            shopPotion.Add(new Potion("초급회복물약", 30, 150, 1, PotionType.HealPotion));
        }
        int a = 1;
        public void ViewShop()
        {
            foreach (var item in shopItems)
            {
                Console.Write(a++ + " ");
                item.Equipments();
                Console.Write($"{item.Price}Gold\t");
                Console.WriteLine(" ");

            }

        }
        public void ViewPotionShop()
        {
            foreach (var potion in shopPotion)
            {
                Console.Write(a++ + " ");
                potion.Potions();
                Console.Write($"{potion.Price}Gold\t");
                Console.WriteLine();
                
            }
        }
        public void ShopManger(ref Player player, Inventory inven)
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine($"보유골드 {player.Gold}");
            Console.WriteLine("아이템 목록");
            ViewShop();
            for (int i = 0; i < shopItems.Count; i++)
            {
               
                if (shopItems[i].IsBuy == true)
                {
                    Console.WriteLine("구매완료");
                }
            }
                ViewPotionShop();
            
            Console.WriteLine("0. 상점 나가기\n구매하실 물품의 번호를 입력해주세요");
            Console.WriteLine("=========================================");

            //Inventory.itemInventory.Add();
        }
    }
}
