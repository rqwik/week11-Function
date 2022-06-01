using System;

namespace CToF
{
    class Program
    {
        static void Main(string[] args)
        {
            takeChoose();
        }
        public static void takeChoose()
        {
            Console.Write("В чем проверить температуру. Выбери фарингейты (нажми F) или цельсии (нажми C):");
            int i = 0;
            while (i < 10)
            {
                char userChoice = Convert.ToChar(Console.ReadLine().ToUpper());
                if (userChoice == 'F')
                {
                    Console.WriteLine("Введи температуру в фарингейтах");
                    int far = Convert.ToInt32(Console.ReadLine());
                    int CelSum = (far - 32) * 5 / 9;
                    Console.WriteLine($"Температура {CelSum} C");
                }
                else if (userChoice == 'C')
                {
                    Console.WriteLine("Введи температуру в цельсиях");
                    int cel = Convert.ToInt32(Console.ReadLine());
                    int FarSum = (cel * 9 / 5) + 32;
                    Console.WriteLine($"Температура {FarSum} F");
                }
                else
                {
                    i++;
                    Console.WriteLine($"Проверь вводимый символ и попробуй еще раз:");
                }
            }
        }        
    }
}
