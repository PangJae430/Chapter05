using System;

namespace p151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            for (int i = 0; i < 5; i++) 
            {
                Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요. ");
                string input1 = Console.ReadLine();

                Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요. ");
                string input2 = Console.ReadLine();

                Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요. ");
                string input3 = Console.ReadLine();

                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);
                int number3 = Convert.ToInt32(input3);
                int value1 = 0;
                value1 = number1 + number2 + number3;
                int value2 = 0;
                value2 = (number1 + number2 + number3) / 3;

                if (number1 >= number2)
                {
                    if (number1 >= number3)
                        max = number1;
                    else
                        max = number3;
                }
                else
                {
                    if (number2 >= number3)
                        max = number2;
                    else
                        max=number3;
                }
                if(number1 <= number2)
                {
                    if (number1 <= number3)
                        min = number1;
                    else
                        min = number3;
                }
                else
                {
                    if (number2 <= number3)
                        min = number2;
                    else
                        min = number3;
                }
                Console.WriteLine($"입력하신 {number1}, {number2}, {number3} 중 최대값은 {max}이며 최소값은 {min} 입니다.");
                Console.WriteLine($"입력하신 {number1}, {number2}, {number3} 의 합은 {value1}이며, 평균은 {value2} 입니다.");
                return;
            }
        }
    }
}
