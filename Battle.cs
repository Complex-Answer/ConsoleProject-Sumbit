using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    class Battle
    {
        Random rnd = new Random(); //랜덤으로 만들어낼 상수 하나 만들어주고
        protected List<MonsterBattle> monsters = new List<MonsterBattle>();//자식 클래스를 배열로 만들 준비

        bool super;
        public int RndMonster()
        {
            int a = rnd.Next(0, monsters.Count);
            return a;
        }
        public void AddMonster() // 여러 몬스터를 추가하는 배열
        {
            monsters.Add(new Slime());
            monsters.Add(new Golem());
            monsters.Add(new Skeleton());
        }
        public void BattleMonster(ref Player player)
        {
            super = true;
            AddMonster();
            bool game = true;
                Console.Clear();
            while (game)
            {

                if (super == false)
                {
                    break;
                }
                Console.WriteLine("던전을 탐색중입니다...");
                Thread.Sleep(2000);

                int a = RndMonster();
                Console.WriteLine(monsters[a].Name + "(이)가 나타났습니다!"); //랜덤 상수을 인덱스로 받아 이름을 출력하는 장치
                
                Console.WriteLine("[1]: 전투!");
                Console.WriteLine("[2]: 후퇴한다");
                
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.Clear();
                        Fight(ref player);
                        if (player.PlayerHp <= 0)
                        {
                            game = false;
                        }
                        

                    }
                    else if (input == "2")
                    {
                        Random rnd = new Random();
                        int rand = rnd.Next(0, 101);
                        if (rand <= 40)
                        {
                            Console.WriteLine("무사히 도망쳤습니다");
                            Thread.Sleep(500);
                            
                            break;

                        }
                        else
                        {
                            Console.WriteLine("도망칠때 기습을 당했습니다...\n현재 체력의 10%데미지를 입습니다.");
                            Thread.Sleep(1000);
                            player.PlayerHp -= (int)(player.PlayerHp * 0.1);
                            Thread.Sleep(1000);
                            Console.WriteLine($"현재 체력 : {player.PlayerHp}");
                            Thread.Sleep(1000);
                            
                            break;
                        }
                    }

                Console.Clear();
                
            }
        }

        
        public void Fight(ref Player player)
        {
            bool game = true;
            int a = rnd.Next(0, monsters.Count);
            while (monsters[a].Hp > 0 && game) //몬스터와 공방을 반복적으로 실행. Hp가 0이하가 될 때 까지
            {
                Console.WriteLine("행동을 입력해주세요");
                Console.WriteLine("A.싸운다   B.포션 사용   C.도망친다");
                ConsoleKeyInfo battleKey = Console.ReadKey(true);
                switch (battleKey.Key)
                {
                    case ConsoleKey.A:
                        {
                            player.Attack(monsters[a]);
                            break;
                        }
                    case ConsoleKey.B:
                        {

                            Inventory.PotionShow();
                            Console.WriteLine("사용할 포션번호를 선택해주세요");
                            int.TryParse(Console.ReadLine(), out int b);
                            if (b <= Inventory.potionInventory.Count)
                            {
                                Potion.PotionUse(Inventory.potionInventory[b - 1], ref player);
                            }
                            else
                            {
                                Console.WriteLine("해당 칸은 없습니다");
                                continue;
                            }
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            Random rnd = new Random();
                            int rand = rnd.Next(0, 101);
                            if (rand <= 40)
                            {
                                Console.WriteLine("무사히 도망쳤습니다");
                                Thread.Sleep(500);
                                Console.WriteLine();
                                game = false;

                                break;
                            }
                            else
                            {
                                Console.WriteLine("도망칠때 기습을 당했습니다...");
                                Thread.Sleep(1000);
                                Console.WriteLine("현재 체력의 10%데미지를 입습니다.");
                                Thread.Sleep(1000);
                                player.PlayerHp -= (int)(player.PlayerHp * 0.1);
                                Console.WriteLine($"현재 체력 : {player.PlayerHp}");
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                game = false;

                                break;
                            }

                        }

                    default:
                        {
                            Console.WriteLine("다시 입력해주세요");
                            continue;
                        }
                }
                if (game == false)
                {
                    super = false;
                    break;
                }
                Console.WriteLine();
                if (monsters[a].Hp <= 0) //hp가 0이면 몬스터데스 함수를 호출해 결과를 출력함
                {
                    monsters[a].Hp = 0;
                    monsters[a].Monsterdeath(monsters[a]);
                    player.GetGold(monsters[a].DropGold);
                    player.GetExp(monsters[a].DropExp);
                    if (player.Exp >= player.MaxExp)
                        player.LevelUP();
                    break;
                }
                monsters[a].MonsterAttack(player);
                Thread.Sleep(1500);
                Console.WriteLine();

                if (player.PlayerHp <= 0)
                {
                    Console.WriteLine("사망하셨습니다");
                    Environment.Exit(0);
                }



            }
        }
    }
}
