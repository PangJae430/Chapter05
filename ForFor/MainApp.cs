using System;

namespace ForFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for(int i=0;1<5;i++)
            {
                for(int j=0; j<=i;j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
