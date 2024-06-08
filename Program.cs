using System;

namespace NumberToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = Convert.ToInt32(Console.ReadLine());

            string romanNumber = LetterNumber(value);
            Console.WriteLine($"Римское число: {romanNumber}");
        }

        static string LetterNumber(int num)
        {
            int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] letters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string digitRoman = ""; // Римское число.

            // конвертируем
            for (int i = 0; i < numbers.Length; i++)
            {
                while (num >= numbers[i])
                {
                    digitRoman += letters[i];
                    num -= numbers[i];
                }
            }
            return digitRoman;
        }
    }
}
