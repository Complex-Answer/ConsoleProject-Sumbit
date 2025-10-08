using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleProject_sumbit
{   public class Item
    {
        public ItemType types;
        public string eqName;
        public bool isEq;
        
        public virtual void Equipments()
        {

        }
        protected int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        protected int sellPrice;
        public int SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }
        protected bool isBuy;
        public bool IsBuy
        {
            get { return isBuy; }
            set { isBuy = value; }
        }
        protected bool isSell;
    }
    public enum ItemType //아이템 장비를 검, 장패 ,갑옷으로 구분
    {
        Sword, Shield, Armor
    }
    public class ItemStore : Item//장비, 포션들을 살 수 있는 상속 부모 클래스
    {
        
    }
     class Sword : Item //장비의 스탯, 장착여부, 타입을 설정
    {
       
        int Att;
        static public int SwordAtt
        {
            get; set;
        }
       

        public Sword(string name, int att,  int price,  ItemType type)
        {
            eqName = name;
            Att = att;
            Price = price;
            SellPrice = (int)(price * 0.7);
            
            isEq = false;
            types = type;
        }
        public override void Equipments() //각 타입에 맞게 공격력과 방어력을 설정 및 출력
        {
            
            Console.WriteLine($"{eqName} : 공격력 {Att}");
            
            
        }
    }
     class Shiled : Item //장비의 스탯, 장착여부, 타입을 설정
    {
        
        int Att;
        static public int ShiledAtt
        {
            get; set;
        }
        int Def;
        static public int ShiledDef
        {
            get; set;
        }


        public Shiled(string name, int att, int def,  int price,   ItemType type)
        {
            eqName = name;
            Att = att;
            Def = def;
            Price = price;
            SellPrice = (int)(price * 0.7);
           
            isEq = false;
            types = type;
        }
        public override void Equipments() //각 타입에 맞게 공격력과 방어력을 설정 및 출력
        {
            Console.WriteLine($"{eqName} : 공격력 {Att} | 방어력 {Def}");
        }
    }
     class Armor : Item //장비의 스탯, 장착여부, 타입을 설정
    {
       
        int MaxHp;
        static public int ArmorMaxHP
        {
            get; set;
        }
        int Def;
        static public int ArmorDef
        {
            get; set;
        }


        public Armor(string name, int def, int addHp, int price, ItemType type)
        {
            eqName = name;
            Def = def;
            MaxHp = addHp;
            Price = price;
            SellPrice = (int)(price * 0.7);
            isEq = false;
            types = type;
        }
        public override void Equipments() //각 타입에 맞게 공격력과 방어력을 설정 및 출력
        {
            Console.WriteLine($"{eqName} : 방어력 {Def} | 최대 체력 {MaxHp}");
        }
    }
    enum PotionType
    {
        HealPotion, ManaPotion
    }
    class Potion : Item
    {
        Player player;
        string potionName;
        int potionCount;
        int potionRecovery;
        PotionType potionType;
        public Potion(string name, int value,int price, int count, PotionType type)
        {
            potionName = name;
            potionRecovery = value;
            potionCount = count;
            Price = price;
            SellPrice = (int)(price * 0.7);
            potionType = type;
        }
        public void Potions() //포션 종류에 맞게 회복량 출력
        {
            if (potionType == PotionType.HealPotion)
            {
                Console.WriteLine($"{potionName} : 체력회복량 {potionRecovery} |{potionCount}개"); 
            }
            else if (potionType == PotionType.ManaPotion)
            {
                Console.WriteLine($"{potionName} : 마나회복량 {potionRecovery} |{potionCount}개");
            }
            else
            {
                Console.WriteLine("포션이 없습니다");
            }
        }
        public void PotionUse(Potion potion)
        {
            Console.Write($"{potion.potionName}을 사용했습니다.");
            if (potionType == PotionType.HealPotion)
            { 
                Console.WriteLine($" {potion.potionRecovery}만큼 체력을 회복했습니다");
                Player.PlayerHp += potion.potionRecovery;
                potion.potionCount--;
            }
            else if (potionType == PotionType.ManaPotion)
            {
                Console.WriteLine($"{potion.potionRecovery}만큼 마나를 회복했습니다");
                Player.PlayerMp += potion.potionRecovery;
                potion.potionCount--;
            }
            else if (potionCount <= 0) 
            {
                Console.WriteLine("사용할 포션이 없습니다!");
            }
        }
    }
}
