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
        public List<Potion> potionInventory = new List<Potion>();

        public void ItemAdd(Item item) //아이템 추가
        {
            itemInventory.Add(item);
        }
        public void ItemRemove(int a) //아이템 제거 및 확인내용
        {
            Console.Clear();
            itemInventory.RemoveAt(a);
            Console.WriteLine($"아이템 {a+1}번을 삭제했습니다.");
        }
        public void ItemShow() //보유중인 아이템 출력
        {
            foreach (var i in itemInventory)
            {
                Console.WriteLine(i);
            }
        }
        public void PotionAdd(Potion potion) //아이템 추가
        {
            potionInventory.Add(potion);
            
        }
        public void PotionRemove(int a) //아이템 제거 및 확인내용
        {
            Console.Clear();
            potionInventory.RemoveAt(a);
            Console.WriteLine($"포션 {a+1}번을 삭제했습니다.");
        }
        public void PotionShow() //보유중인 아이템 출력
        {
            foreach (var i in potionInventory)
            {
                Console.WriteLine(i);
            }
        }
        public void ShowInventory()
        {
            Console.WriteLine("현재 보유 중인 장비 목록");
            ItemShow();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("현재 보유 중인 포션 목록");
            PotionShow();
        }
    }
}
