using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, шестизначное число:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            DigitsExtractor extractror = new DigitsExtractor();
            int[] firstTreeDigits = extractror.ExctractTreeDigits(number);
            int[] secondFirstTreeDigits = extractror.ExctractTreeDigits(number/1000);
            int firstSum = firstTreeDigits[0] + firstTreeDigits[1] + firstTreeDigits[2];
            int secondSum = secondFirstTreeDigits[0] + secondFirstTreeDigits[1] + secondFirstTreeDigits[2];
            if(firstSum == secondSum)
            {
                Console.WriteLine("Поздравляем! Ваше число - счастливое :3");
            }
            else
            {
                Console.WriteLine("Извините, но ваше число - не счастливое :с");
            }
           
            Console.ReadKey();  //аналог getch();
        }
    }
}
