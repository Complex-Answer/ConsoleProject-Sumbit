using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
     static class Dice
    {
        
        static int Diceroll
        {
            get; set;
        }
         static public double PlayerRollDice()//플레이어 전용
        {
            Random pDice = new Random();
            new Random(DateTime.Now.Millisecond);
            Diceroll  = pDice.Next(1, 7);



            Console.WriteLine($"플레이어가 주사위를 굴려 {Diceroll}(이)가 나왔습니다");
            return Math.Log(Diceroll)*Diceroll;//주사위에서 나온 수에 로그를 씌워서 최대한 대미지 가중치 계산
        }
        static public double EnemyRollDice() //적전용
        {
            Random eDice = new Random();
            new Random(DateTime.Now.Millisecond);
            Diceroll  = eDice.Next(1, 7);

            Console.WriteLine($"적이 주사위를 굴려 {Diceroll}(이)가 나왔습니다");
            return Math.Log(Diceroll)*Diceroll;//주사위에서 나온 수에 로그를 씌워서 최대한 대미지 가중치 계산
        }

    }
}
