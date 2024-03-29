﻿using System;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. : ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            string value = "0";

            switch(number)
            {
                case 3: case 4: case 5:
                    value = "봄";
                    break;
                case 6: case 7: case 8:
                    value = "여름";
                    break;
                case 9: case 10: case 11:
                    value = "가을";
                    break;
                case 12: case 2: case 1:
                    value = "겨울";
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
                    return;
            }
            Console.WriteLine($"입력하신 {number}월은 {value} 입니다.");
        }
    }
}
