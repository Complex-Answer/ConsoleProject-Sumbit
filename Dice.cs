using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    internal class Dice
    {
        Random rnd = new Random();

        int rndDice;
        
        public void RollDice()
        {
            rndDice = rnd.Next(1, 7);

            Console.WriteLine($"주사위를 굴려 {rndDice}(이)가 나왔습니다");
        }

    }
}
