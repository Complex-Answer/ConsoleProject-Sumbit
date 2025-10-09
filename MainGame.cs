using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleProject_sumbit
{
    internal class MainGame
    {
        public void GameManger()
        {
            Console.WriteLine("캐릭터의 이름을 입력해주십시오");
            Player player = new Player(Console.ReadLine());
            Battle battle = new Battle();
            EquipManger equip = new EquipManger();
            Inventory inven = new Inventory();
            Shop shop = new Shop();



            Console.WriteLine("다음으로 넘어가려면 스페이스바 또는 엔터키를 입력해주세요");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.Enter) //그래도 스페이스또는 엔터로 유지
                {
                    Console.Clear();
                    Console.WriteLine("환영합니다. 해당 게임은 던전에서 살아남아 어디까지 진행 되는지 가늠하는 테스트 게임입니다");
                    Thread.Sleep(3000);
                    Console.WriteLine("게임을 시작할 준비가 되셨다면 스페이스바를 눌러주세요");
                    Console.WriteLine("또는 게임을 종료하시려면 esc키를 눌러주세요");
                    while (true)
                    {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Spacebar)
                        {
                            Console.Clear();
                            Console.WriteLine("1. 던전\t2. 상점\t 3.장비창\t 4.종료");
                            int.TryParse(Console.ReadLine(), out int num);
                            switch (num)
                            {
                                case 1:
                                    {
                                        battle.BattleMonster(ref player);
                                        break;
                                    }
                                case 2:
                                    {
                                        shop.ShopSetting();
                                        shop.ShopManger(ref player, inven);
                                        break;
                                    }
                                case 3:
                                    {

                                        equip.PlayerEquip(ref player);
                                        break;
                                    }
                                case 4:
                                    return;
                                default:
                                    Console.WriteLine("1~4까지의 숫자만 입력해주세요");
                                    break;
                            }
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
        }
    }
}
