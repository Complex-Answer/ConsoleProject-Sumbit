using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    public enum ItemType //아이템 장비를 검, 장패 ,갑옷으로 구분
    {
        Sword, Shield, Armor
    }
    public class ItemStore //장비, 포션들을 살 수 있는 상속 부모 클래스
    {
        protected int Price;
        protected bool isBuy;
        protected bool isSell;
    }
     class Item : ItemStore //장비의 스탯, 장착여부, 타입을 설정
    {
        string eqName;
        string eqInfo;
        int Att;
        int Def;
        bool isEq;
        ItemType types;


        public Item(string name, string eqinfo, int att, int def, bool iseq, int price, ItemType item
            , bool buy, bool sell)
        {
            eqName = name;
            eqInfo = eqinfo;
            Att = att;
            Def = def;
            isEq = iseq;
            Price = price;
            types = item;
            isBuy = buy;
            isSell = sell;
        }
        public override string ToString() //각 타입에 맞게 공격력과 방어력을 설정 및 출력
        {
            if (types == ItemType.Sword)
            {
                return $"{eqName} : 공격력 {Att}";
            }
            else if (types == ItemType.Shield)
            {
                return $"{eqName} : 공격력 {Att}  방어력 {Def}";
            }
            else if (types == ItemType.Armor)
            {
                return $"{eqName} : 방어력 {Def}";
            }
            else
            {
                return "아이템이 없습니다";
            }
        }

    }
    enum PotionType
    {
        HealPotion, ManaPotion
    }
    class Potion : ItemStore
    {
        string potionName;
        int potionCount;
        int potionRecovery;
        PotionType potionType;
        public Potion(string name, int value, int count, PotionType type)
        {
            potionName = name;
            potionRecovery = value;
            potionCount = count;
            potionType = type;
        }
        public override string ToString() //포션 종류에 맞게 회복량 출력
        {
            if (potionType == PotionType.HealPotion)
            {
                return $"{potionName} : 체력 회복량 {potionRecovery} {potionCount}개";
            }
            else if (potionType == PotionType.ManaPotion)
            {
                return $"{potionName} : 마나 회복량 {potionRecovery} {potionCount}개";
            }
            else
            {
                return "포션이 없습니다";
            }
        }

    }
}
