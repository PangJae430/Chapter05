using System;

namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요! ");

            Console.Write("첫 번째 정수를 입력해주세요.");
            string input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.Write("두 번째 정수를 입력해주세요.");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            Console.Write("연산기호를 입력해주세요. ex)+,-,*,/,% : ");
            string input3 = Console.ReadLine();

            int value = 0;

            switch (input3)
            {
                case "+":
                    value = number1 + number2;
                    break;
                case "-":
                    value = number1 - number2;
                    break;
                case "*":
                    value = number1 * number2;
                    break;
                case "/":
                    value = number1 / number2;
                    break;
                case "%":
                    value = number1 % number2;
                    break;
                default:
                    Console.WriteLine("입력하신 연산기호는 잘못되었습니다. 다시 한 번 확인하여 주십시오.");
                    return;
            }

            Console.WriteLine($"입력하신 {number1}{input3}{number2}의 결과값은 {value} 입니다.");
        }
    }
}
