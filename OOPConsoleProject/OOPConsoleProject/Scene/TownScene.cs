﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scene
{
    class TownScene : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("장소 : 초보자의 마을");
            Console.WriteLine("활기찬 마을이다");
            Console.WriteLine();
            Console.WriteLine("1. 필드로 나간다");
            Console.WriteLine("어디로 가시겠습니까? ");

        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            throw new NotImplementedException();
        }


        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("마을 밖으로 나갑니다");
                    Game.ChangeScene("Field");
                    break;
            }
        }

        
    }
}
