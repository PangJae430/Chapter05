using System;

namespace p151_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("정수 한 개를 입력하세요 : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if(number % 3 == 0)
            { Console.WriteLine("")}
        }
    }
}
