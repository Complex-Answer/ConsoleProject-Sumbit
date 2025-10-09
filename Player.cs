using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    public class Player
    {
         string name;
         public string PlayerName { get; set; }
         int Level;
        static int MaxHp; //프로퍼티 
         int Hp; //프로퍼티
         int Mp;
         int MaxMp;
        static public int PlayerMaxHp
        {
            get; set;
        }
         
         public int PlayerHp
        {
            get { return Hp; }
            set { Hp = value; }
        }
         public int PlayerMp
        {
            get { return Mp; }
            set { Mp = value; }
        }
         int Att; 
         public int PlayerAtt
        {
            get; set;
        }//프로퍼티
         int Def;
         public int PlayerDef
        {
            get; set;
        }//프로퍼티
         int gold;
         public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }//외부에 노출을 시켜야됨 근데 노출시키기가 싫음
         double exp;
        public double Exp{
            get { return exp; }
            set { exp = value; }
        }//프로퍼티
        static double maxExp;
        public double MaxExp
        {
            get { return maxExp; }
            set { maxExp = value; }
        }



        public Player(string Inputname)  //플레이어 생성시 이름을 입력받고 기본적인 스탯 제공
        {
            PlayerName = Inputname;
            Level = 1;
            PlayerHp = 50;
            MaxHp = 50;
            PlayerMp = 30;
            MaxMp = 30;
            Att = 5;
            Def = 3;
            Gold = 500;
            Exp = 0;
            MaxExp = 60;
            Console.Clear();
            Console.WriteLine($"{PlayerName} 캐릭터가 생성되었습니다");

        }
        public void CharInfo()
        {
            Console.WriteLine("캐릭터 이름 : " + name);
            Console.WriteLine("레벨 : " + Level);
            Console.WriteLine("현재 체력 : " + Hp + "/" + MaxHp);
            Console.WriteLine("공격력 : " + Att);
            Console.WriteLine("방어력 : " + Def);
            Console.WriteLine("현재 골드 : " + Gold);
            Console.WriteLine("현재 경험치 : " + Exp + "/" + MaxExp);
        }
        public void Attack(MonsterBattle monster) //플레이어 공격 메서드
        {
            monster.monsterTakenDamage(Att + (int)Dice.PlayerRollDice());
        }
        public void Taken(int damage)
        {
            Hp = Hp - damage;
            Console.WriteLine($"{PlayerName}이(가) {damage}만큼 피해를 입었습니다");
            if (Hp <= 0)
            {
                Hp = 0;
            }
            Console.WriteLine($"현재 {PlayerName} 체력 : {PlayerHp}");
        }
        public void LevelUP()
        {
            if (Exp >= MaxExp)
            {
                Level++;
                Console.WriteLine("레벨이 올랐습니다");
                Console.WriteLine($"현재 레벨 : {Level}");
                Att += 2;
                Def += 2;
                MaxHp += 50;
                if (MaxExp - Exp > 0)
                {
                    Exp = MaxExp - Exp;
                }
                else if (MaxExp - Exp == 0)
                {
                    Exp = 0;
                }
                MaxExp = (MaxExp * 1.5) + 30;

            }

        }
        public void GetExp(double exp)
        {
            Exp += exp;
        }
        public void GetGold(int gold)
        {
            Gold += gold;
        }

    }
}
