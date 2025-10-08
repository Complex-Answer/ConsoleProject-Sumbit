using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    class EquipManger
    {
        

        public void PlayerEquip(ref Player player)
        {
            var inventory = Inventory.itemInventory;
            List<Item> eqItem = new List<Item>
            {
                Capacity = 5
            };
            Console.Clear();
            Console.WriteLine("장비창\n보유중인 아이템을 장착할 수 있습니다");
            Console.WriteLine("아이템은 종류 상관없이 최대 5개 까지 장착 가능합니다");
            Console.WriteLine("[아이템 목록]");
            Inventory.ItemShow();
            bool game = true;
            while (game)
            {
                if (eqItem.Count >= 5)
                {
                    Console.WriteLine("더 이상 아이템을 장착할 수 없습니다");
                    Console.WriteLine("0. 장비창 닫기\t1. 장비 해제");
                    Console.WriteLine("=========================================");
                    bool inputNum = int.TryParse(Console.ReadLine(), out int num);

                    if (num == 0)
                    {
                        game = false;
                        
                    }

                    else if (num == 1)
                    {
                        int.TryParse(Console.ReadLine(), out int eqNum);
                        if (inventory[eqNum - 1].isEq == false)
                        {
                            inventory[eqNum - 1].isEq = true;
                            if (inventory[eqNum - 1].types == ItemType.Sword)
                            {
                                Player.PlayerAtt -= Sword.SwordAtt;
                            }
                            else if (inventory[eqNum - 1].types == ItemType.Shield)
                            {
                                Player.PlayerAtt -= Shiled.ShiledAtt;
                                Player.PlayerDef -= Shiled.ShiledDef;
                            }
                            else if (inventory[eqNum - 1].types == ItemType.Armor)
                            {
                                Player.PlayerDef -= Armor.ArmorDef;
                                Player.PlayerMaxHp -= Armor.ArmorMaxHP;
                            }
                            Console.WriteLine($"{inventory[eqNum - 1].eqName}를 장착 해제했습니다");
                            eqItem.Remove(inventory[eqNum - 1]);
                        }
                        else if (inventory[eqNum - 1].isEq == true)
                        {
                            Console.WriteLine("아이템을 장착하지 않았습니다");
                        }
                    }
                    else
                    {
                        Console.WriteLine("다시 입력해주세요");
                    }
                }
                else if (eqItem.Count < 5)
                {
                    Console.WriteLine("0. 장비창 닫기\t1. 장비 장착\t2. 장비 해제");
                    Console.WriteLine("=========================================");
                    bool inputNum2 = int.TryParse(Console.ReadLine(), out int num2);

                    if (num2 == 0)
                    {
                        game = false;
                        ;
                    }
                    else if (num2 == 1)
                    {
                        int.TryParse(Console.ReadLine(), out int eqNum);
                        if (inventory[eqNum - 1].isEq == false)
                        {
                            inventory[eqNum - 1].isEq = true;
                            if (inventory[eqNum - 1].types == ItemType.Sword)
                            {
                                Player.PlayerAtt += Sword.SwordAtt;
                            }
                            else if (inventory[eqNum - 1].types == ItemType.Shield)
                            {
                                Player.PlayerAtt += Shiled.ShiledAtt;
                                Player.PlayerDef += Shiled.ShiledDef;
                            }
                            else if (inventory[eqNum - 1].types == ItemType.Armor)
                            {
                                Player.PlayerDef += Armor.ArmorDef;
                                Player.PlayerMaxHp += Armor.ArmorMaxHP;
                            }
                            Console.WriteLine($"{inventory[eqNum - 1].eqName}를 장착 했습니다");
                            eqItem.Add(inventory[eqNum - 1]);
                        }
                        else if (inventory[eqNum - 1].isEq == true)
                        {
                            Console.WriteLine("이미 장착한 아이템입니다");
                        }

                    }
                    else if (num2 == 2)
                    {
                        int.TryParse(Console.ReadLine(), out int eqNum);
                        if (inventory[eqNum - 1].isEq == false)
                        {
                            inventory[eqNum - 1].isEq = true;
                            if (inventory[eqNum - 1].types == ItemType.Sword)
                            {
                                Player.PlayerAtt -= Sword.SwordAtt;
                            }
                            else if (inventory[eqNum - 1].types == ItemType.Shield)
                            {
                                Player.PlayerAtt -= Shiled.ShiledAtt;
                                Player.PlayerDef -= Shiled.ShiledDef;
                            }
                            else if (inventory[eqNum - 1].types == ItemType.Armor)
                            {
                                Player.PlayerDef -= Armor.ArmorDef;
                                Player.PlayerMaxHp -= Armor.ArmorMaxHP;
                            }
                            Console.WriteLine($"{inventory[eqNum - 1].eqName}를 장착 해제했습니다");
                            eqItem.Remove(inventory[eqNum - 1]);
                        }
                        else if (inventory[eqNum - 1].isEq == true)
                        {
                            Console.WriteLine("아이템을 장착하지 않았습니다");
                        }

                    }
                    else
                    {
                        Console.WriteLine("다시 입력해주세요");
                    }

                }
            }
        }
    }
}
