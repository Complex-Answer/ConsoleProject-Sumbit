using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    class Battle
    {
        Random rnd = new Random(); //랜덤으로 만들어낼 상수 하나 만들어주고
       protected List<MonsterBattle> monsters = new List<MonsterBattle>();//자식 클래스를 배열로 만들 준비
        public void AddMonster() // 여러 몬스터를 추가하는 배열
        {
            monsters.Add(new Slime());
            monsters.Add(new Golem());
            monsters.Add(new Skeleton());
        }
        public void BattleMonster(ref Player player)
        {
            AddMonster();
            while (true)
            {
                Console.WriteLine("던전을 탐색중입니다...");
                //Thread.Sleep(3000);
                
                int a = rnd.Next(0, monsters.Count);
                Console.WriteLine(monsters[a].Name + "(이)가 나타났습니다!"); //랜덤 상수을 인덱스로 받아 이름을 출력하는 장치

                Console.WriteLine("[1]: 전투!");
                Console.WriteLine("[2]: 후퇴한다");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Fight(player);
                }
                else if (input == "2")
                {
                    Random rnd = new Random();
                    int rand = rnd.Next(0, 101);
                    if(rand <= 40)
                    {
                        Console.WriteLine("무사히 도망쳤습니다");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("도망칠때 기습을 당했습니다...\n현재 체력의 10%데미지를 입습니다.");
                        Player.PlayerHp -= (int)(Player.PlayerHp * 0.1);
                        Console.WriteLine($"현재 체력 : {Player.PlayerHp}");

                        break;
                    }


                }
                

            }

        }
        public void Fight(Player player)
        {
            
            int a = rnd.Next(0, monsters.Count);
            while (monsters[a].Hp > 0) //몬스터와 공방을 반복적으로 실행. Hp가 0이하가 될 때 까지
            {
                player.Attack(monsters[a]);
                Console.WriteLine();
                if (monsters[a].Hp <= 0) //hp가 0이면 몬스터데스 함수를 호출해 결과를 출력함
                {
                    monsters[a].Hp = 0;
                    monsters[a].Monsterdeath(monsters[a]);
                    break;
                }
                monsters[a].MonsterAttack(player);
                Console.WriteLine();
                if (Player.PlayerHp <= 0)
                {
                    Console.WriteLine("사망하셨습니다");
                    break;
                }

               
            }
        }
    }
}
