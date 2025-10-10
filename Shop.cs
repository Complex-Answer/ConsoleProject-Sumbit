using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    class Shop
    {
        List<Item> shopItems = new List<Item>();
        List<Potion> shopPotion = new List<Potion>();
        
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
                Console.Write($"{item.Price}Gold");

                if (item.IsBuy == true)
                {
                    Console.WriteLine("   [구매완료]");
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
            
        }
        public void Rest(Player player)
        {
            if (player.Gold < 500)
            {
                Console.WriteLine("골드가 부족합니다");
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("최대체력의 30%를 회복합니다");
                player.PlayerHp += (int)(Player.PlayerMaxHp * 0.3);
                Thread.Sleep(1500);
                Console.WriteLine("휴식을 취해 건강해졌다");
                Thread.Sleep(2000);
                player.Gold -= 500;
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
            a = 1;
        }
        public void ShopManger(ref Player player, Inventory inven)
        {
            bool game = true;
            while (game)
            {
                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine($"보유골드 {player.Gold}");
                Console.WriteLine("아이템 목록");
                ViewShop();
                ViewPotionShop();

                Console.WriteLine($"{shopItems.Count+shopPotion.Count+1}. 휴식하기\n500Gold");
                Console.WriteLine("0. 상점 나가기");
                Console.WriteLine("구매하실 물품의 번호를 입력해주세요");
                Console.WriteLine("=========================================");

                int.TryParse(Console.ReadLine(), out int buy);
                int shops = shopItems.Count;
                int potions = shopPotion.Count;

                if (buy == 0)
                {
                    game = false;
                    Console.WriteLine("스페이스바를 눌러주세요");
                }
                else if (buy > 0 && buy <= shops + potions && buy<= shops)
                {
                    if (shopItems[buy - 1] != null)
                    {


                        if (shopItems[buy - 1].IsBuy == false)
                        {
                            if (player.Gold >= shopItems[buy - 1].Price)
                            {
                                shopItems[buy - 1].IsBuy = true;
                                player.Gold -= shopItems[buy - 1].Price;
                                Inventory.itemInventory.Add(shopItems[buy - 1]);
                                Console.WriteLine($"{shopItems[buy - 1].eqName}을 구매했습니다");
                                Thread.Sleep(500);

                            }
                            else if (player.Gold < shopItems[buy - 1].Price)
                            {
                                Console.WriteLine("골드가 부족합니다");
                                Thread.Sleep(500);
                            }
                        }
                    }
                }
                else if (buy > 0 && buy <= shops + potions)
                {
                    if (shopPotion[buy - shops - 1] != null)
                    {


                        if (shopPotion[buy - shops - 1].IsBuy == false)
                        {
                            if (player.Gold >= shopPotion[buy - shops - 1].Price)
                            {
                                player.Gold -= shopPotion[buy - shops - 1].Price;
                                Inventory.potionInventory.Add(shopPotion[buy - shops - 1]);
                                Console.WriteLine($"{shopPotion[buy - shops - 1].PotionName}을 구매했습니다");
                                Thread.Sleep(500);

                            }
                            else if (player.Gold < shopPotion[buy - shops - 1].Price)
                            {
                                Console.WriteLine("골드가 부족합니다");
                                Thread.Sleep(500);
                            }
                        }
                    }
                   
                }
                else if (buy == shops + potions + 1)
                {
                    Rest(player);
                }
                else
                {
                    Console.WriteLine("다시 입력해주세요");
                    Thread.Sleep(500);
                }

            }
        }
    }
}
