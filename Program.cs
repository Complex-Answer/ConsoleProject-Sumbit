using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleProject_sumbit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DungeonManager dun = new DungeonManager();
            dun.AddMonster();
            Console.WriteLine("캐릭터의 이름을 입력해주십시오");
            Player player = new Player(Console.ReadLine());

            Console.WriteLine("다음으로 넘어가려면 스페이스바 또는 엔터키를 입력해주세요"); //아무 키로 하고싶었는데 어케함??
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.Enter) //그래도 개?연성 있게 스페이스또는 엔터로 일단 유지
                {
                    //Console.Clear();
                    //Console.WriteLine("환영합니다. 해당 게임은 던전에서 살아남아 어디까지 진행 되는지 가늠하는 테스트 게임입니다");
                    //Thread.Sleep(3000);
                    //Console.WriteLine("던전으로 입장하시면 패배할 때 까지 나오지 못하는 하드코어 로그라이크입니다");
                    //Thread.Sleep(3000);
                    Console.WriteLine("게임을 시작할 준비가 되셨다면 스페이스바를 눌러주세요");
                    Console.WriteLine("또는 게임을 종료하시려면 esc키를 눌러주세요");
                    while (true)
                    {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Spacebar)
                        {
                            Console.Clear();
                            Console.WriteLine("던전 입장");
                            dun.EncounterMonster();
                        }
                        else if (key.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("시작하시려면 스페이스바를 눌러주세요");
                            continue;
                        }
                    }


              
                }
                else
                {
                    Console.WriteLine("스페이스바 또는 엔터키를 입력해주세요");
                    continue;
                }
            }
            //key = Console.ReadKey();// 밑에 스위치문 받을라고 쓴거임
            //switch (key.Key)
            //{
            //    case ConsoleKey.NumPad1:
            //        {
            //            //갈곳1
            //            break;
            //        }         
            //    case ConsoleKey.NumPad2:
            //        {
            //            //갈곳2
            //            break;
            //        }         
            //    case ConsoleKey.NumPad3:
            //        {
            //            //갈곳3
            //            break;
            //        }         
                    
                
                


            //}
        }
    }
}
