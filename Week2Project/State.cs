using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Project
{
    internal class State
    {
        public int Level = 1;
        public string Chad = "(전사)";
        public string Name = " ";
        public float Attack = 10;
        public int Defense = 5;
        public int Hp = 100;
        public int Gold = 1500;


        public void PlayerState()
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

                Console.WriteLine($"Lv : {Level}");
                Console.WriteLine($"직업 : {Chad}");
                Console.WriteLine($"공격력 : {Attack}");
                Console.WriteLine($"방어력 : {Defense}");
                Console.WriteLine($"체 력 : {Hp}");
                Console.WriteLine($"Gold : {Gold}");
                Console.WriteLine();

                Console.WriteLine($"0. 나가기\n");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.WriteLine(">>");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    return;
                }
            }
        }
    }
}
