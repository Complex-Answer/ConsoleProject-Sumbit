using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    internal class Player
    {
        string name;
        int Level;
        int MaxHp; //프로퍼티 
        int Hp; //프로퍼티
        int Att; //프로퍼티
        int Def; //프로퍼티
        int Gold; //외부에 노출을 시켜야됨 근데 노출시키기가 싫음
        double Exp; //프로퍼티
        double MaxExp; //프로퍼1티

        public Player(string Inputname)  //플레이어 생성시 이름을 입력받고 기본적인 스탯 제공
        {
            name = Inputname;
            Level = 1;
            Hp = 50;
            MaxHp = 50;
            Att = 5;
            Def = 3;
            Gold = 0;
            Exp = 0;
            MaxExp = 60;
            Console.Clear();
            Console.WriteLine($"{name} 캐릭터가 생성되었습니다");

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
        public void Attack() //플레이어 공격 메서드
        {
            Dice playerDice = new Dice();
            int attackPower = Att +((int)playerDice.PlayerRollDice());
            Console.WriteLine($"{name}이(가) {attackPower}만큼 공격했습니다");
        }
        public void Taken()
        {

        }
        public void LevelUP()
        {
            if (Exp >= MaxExp)
            {
                Level++;
                Console.WriteLine("레벨이 올랐습니다");
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

    }
}
