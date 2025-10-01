using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    enum ItemType
    {
        Sword, Shield, Armor
    }
    class ItemStore
    {
        protected int Price;
        protected bool isBuy;
        protected bool isSell;
    }
    class Item : ItemStore
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
        public override string ToString()
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
        HealPotion, Manapotion, LuckPotion
    }
    class Potion : ItemStore
    {
        string potionName;
        int potionCount;
        PotionType potionType;


    }
}
