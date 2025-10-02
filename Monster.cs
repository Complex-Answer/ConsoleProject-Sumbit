using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{ 
    
    public class BasicMonster //기본적인 몬스터의 스탯 클래스
    {
        string name;
        int att;
        int def;
        int hp;
        int dropGold;
        float dropExp;
        public string Name { get; set; }
        public int Att {get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int DropGold { get; set; }
        public float DropExp { get; set; }

        public virtual void Monsterdeath()
        {
            if (Hp <= 0)
            {
                Console.WriteLine($"{Name}이(가) 쓰러졌습니다");
            }
        }
    }

    public class Slime : BasicMonster
    {
        public Slime()
        {
            Name = "슬라임";
            Att = 5;
            Def = 12;
            Hp = 50;
            DropExp = 8.5F;
            DropGold = 15;
        }
       
    }
    public class Golem : BasicMonster
    {
        public Golem()
        {
            Name = "골렘";
            Att = 25;
            Def = 40;
            Hp = 200;
            DropExp = 22.4f;
            DropGold = 50;
        }
       
    }
    public class Skeleton : BasicMonster
    {
        public Skeleton()
        {
            Name = "해골 병사";
            Att = 11;
            Def = 8;
            Hp = 90;
            DropExp = 12.5F;
            DropGold = 25;
        }
       
    }
}
