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
        int Hp;
        int Att;
        int Def;
        int Gold;
        float Exp;

        public Player(string Inputname) 
        {
            name = Inputname;
            Hp = 50;
            Att = 10;
            Def = 8;
            Gold = 0;
            Exp = 0;
            Console.Clear();
            Console.WriteLine($"{name} 캐릭터가 생성되었습니다");
        }





    }
}
