using System;

namespace p161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("몇월이 궁금하세요? : ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            switch(number)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine($"{number}월은 31일까지 있습니다");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine($"{number}월은 30일까지 있습니다.");
                    break;
                case 2:
                    Console.WriteLine($"{number}월은 28일까지 있습니다.");
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
                    return;
            }
            
        }
    }
}
