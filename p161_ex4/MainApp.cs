using System;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. : ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            switch(number)
            {
                case 3: case 4: case 5:
                    Console.WriteLine($"입력하신 {number}월은 봄 입니다.");
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine($"입력하신 {number}월은 여름 입니다.");
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine($"입력하신 {number}월은 가을 입니다.");
                    break;
                case 12: case 2: case 1:
                    Console.WriteLine($"입력하신 {number}월은 겨울 입니다.");
                    break;
                default:
                    Console.WriteLine($"입력하신 {number}월은 존재하시 않습니다.다시 입력하여 주십시오.");
                    return;
            }
        }
    }
}
