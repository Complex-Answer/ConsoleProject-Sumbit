using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

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
        public int Att { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int DropGold { get; set; }
        public float DropExp { get; set; }

    }
    public class MonsterBattle : BasicMonster
    {
        public virtual void Monsterdeath(BasicMonster basic) //만약 hp가 0이면 몬스터가 죽는 메세지를 출력
        {
        }

        public virtual void MonsterAttack(Player player)
        {
        }

        public virtual void monsterTakenDamage(int playerDamage) 
        { 
        }

    }


    public class Slime : MonsterBattle
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
        public override void MonsterAttack(Player player)
        {

            player.Taken(Att + (int)Dice.EnemyRollDice());

        }
        public override void Monsterdeath(BasicMonster basic)
        {

            Console.WriteLine($"{Name}이(가) 쓰러졌습니다");
            Console.WriteLine($"{DropExp} 경험치를 획득했습니다");
            Console.WriteLine($"{DropGold} 골드를 획득했습니다");

        }
        public override void monsterTakenDamage(int playerDamage)
        {
            Hp = Hp - playerDamage-Def;
            Console.WriteLine($"{Name}에게 {playerDamage-Def}만큼 피해를 입혔습니다");
            if (Hp <= 0)
            {
                Hp = 0;
            }
            Console.WriteLine($"현재 {Name} 체력 : {Hp}");
        }

    }
    public class Golem : MonsterBattle
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
        public override void MonsterAttack(Player player)
        {
            player.Taken(Att + (int)Dice.EnemyRollDice());
        }
        public override void Monsterdeath(BasicMonster basic)
        {

            Console.WriteLine($"{Name}이(가) 쓰러졌습니다");
            Console.WriteLine($"{DropExp} 경험치를 획득했습니다");
            Console.WriteLine($"{DropGold} 골드를 획득했습니다");

        }
        public override void monsterTakenDamage(int playerDamage)
        {
            Hp = Hp - playerDamage - Def;
            Console.WriteLine($"{Name}에게 {playerDamage - Def}만큼 피해를 입혔습니다");
            if (Hp <= 0)
            {
                Hp = 0;
            }
            Console.WriteLine($"현재 {Name} 체력 : {Hp}");
        }

    }
    public class Skeleton : MonsterBattle
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
        public override void MonsterAttack(Player player)
        {

            player.Taken(Att + (int)Dice.EnemyRollDice());

        }
        public override void Monsterdeath(BasicMonster basic)
        {

            Console.WriteLine($"{Name}이(가) 쓰러졌습니다");
            Console.WriteLine($"{DropExp} 경험치를 획득했습니다");
            Console.WriteLine($"{DropGold} 골드를 획득했습니다");

        }

        public override void monsterTakenDamage(int playerDamage)
        {
            Hp = Hp - playerDamage - Def;
            Console.WriteLine($"{Name}에게 {playerDamage - Def}만큼 피해를 입혔습니다");
            if (Hp <= 0)
            {
                Hp = 0;
            }
            Console.WriteLine($"현재 {Name} 체력 : {Hp}");
            
        }

    }
}
