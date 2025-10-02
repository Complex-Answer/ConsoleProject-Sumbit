using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_sumbit
{
    class DungeonManager
    {

        List<BasicMonster> monsters = new List<BasicMonster>();//자식 클래스를 배열로 만들 준비
        //BasicMonster[] monsters = new BasicMonster[100];

        public void AddMonster() // 여러 몬스터를 추가하는 배열
        {
            monsters.Add(new Slime());
            monsters.Add(new Golem());
            monsters.Add(new Skeleton());
        }
        Random rnd = new Random(); //랜덤으로 만들어낼 상수 하나 만들어주고


        public void EncounterMonster()
        {
            int a = rnd.Next(0, monsters.Count); 
            Console.WriteLine(monsters[a].Name +"(이)가 나타났습니다!"); //랜덤 상수을 인덱스로 받아 이름을 출력하는 장치
        }
    }
}
