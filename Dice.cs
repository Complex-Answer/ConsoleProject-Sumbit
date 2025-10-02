using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
     class Dice
    {
         Random rnd = new Random();
         int rndDice;
        static int Diceroll
        {
            get; set;
        }
         public double PlayerRollDice()//플레이어 전용
        {
            Diceroll  = rnd.Next(1, 7);

            Console.WriteLine($"플레이어가 주사위를 굴려 {Diceroll}(이)가 나왔습니다");
            return Math.Log(Diceroll)*Diceroll;//주사위에서 나온 수에 로그를 씌워서 최대한 대미지 가중치 계산
        }
         public double EnemyRollDice() //적전용
        {
            Diceroll  = rnd.Next(1, 7);

            Console.WriteLine($"적이 주사위를 굴려 {Diceroll}(이)가 나왔습니다");
            return Math.Log(Diceroll)*Diceroll;//주사위에서 나온 수에 로그를 씌워서 최대한 대미지 가중치 계산
        }

    }
}
