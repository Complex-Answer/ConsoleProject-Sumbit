using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleProject_sumbit
{
    public class Player
    {
         string name;
         public string PlayerName { get; set; }
         int Level;
        static int MaxHp; //프로퍼티 
         int Hp;
       
         int Mp;
         int MaxMp;
        static public int PlayerMaxHp
        {
            get { return MaxHp; }
            set { MaxHp = value; }
        }
         
         public int PlayerHp
        {
            get { return Hp; }
            set {
                if (Hp >= MaxHp)
                {
                    Hp = MaxHp;
                } 
                Hp = value; }
        }
         public int PlayerMp
        {
            get { return Mp; }
            set { Mp = value; }
        }
         int Att; 
         public int PlayerAtt
        {
            get { return Att; }
            set {  Att = value; }
        }//프로퍼티
         int Def;
         public int PlayerDef
        {
            get { return Def; }
            set {  Def = value; }
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
            set { if(exp >= MaxExp)
                {
                    exp = MaxExp;
                }
                exp = value; }
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
            Gold = 3000;
            Exp = 0;
            MaxExp = 5;
            Console.Clear();
            Console.WriteLine($"{PlayerName} 캐릭터가 생성되었습니다");

        }
        public void CharInfo()
        {
            Console.Clear();
            Console.WriteLine("캐릭터 이름 : " + PlayerName);
            Console.WriteLine("레벨 : " + Level);
            Console.WriteLine("현재 체력 : " + PlayerHp + "/" + PlayerMaxHp);
            Console.WriteLine("공격력 : " + PlayerAtt);
            Console.WriteLine("방어력 : " + PlayerDef);
            Console.WriteLine("현재 골드 : " + Gold);
            Console.WriteLine("현재 경험치 : " + (int)Exp + "/" + (int)MaxExp);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("돌아가시려면 아무키나 입력해주세요");
            Console.ReadKey();
            return;
        }
        public void Attack(MonsterBattle monster) //플레이어 공격 메서드
        {
            monster.monsterTakenDamage(Att + (int)Dice.PlayerRollDice());
        }
        public void Taken(int damage)
        {
            int take = damage - PlayerDef;
            if (take <= 0)
            {
                take = 0;
            }
            Hp = Hp - take;

            Console.WriteLine($"{PlayerName}이(가) {take}만큼 피해를 입었습니다");
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
                Thread.Sleep(750);
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
                MaxExp = (MaxExp * 1.5) + 10;

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
