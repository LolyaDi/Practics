using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-задание
            Console.Write("Для вычисления функции y=7x^2-3x+4, введите любое число х: ");
            string str = Console.ReadLine();

            const int SEVEN = 7, THREE = 3, FOUR = 4, TWO = 2;

            int x = Convert.ToInt32(str);

            int y = (int)(SEVEN * Math.Pow(x, TWO)) - (THREE * x) + FOUR;

            Console.WriteLine($"Ответ:" +
                              $"\ny = {y}");

            // 2-задание
            Console.Write("\nВведите радиус окружности для вычисления длины и площади круга: ");
            str = Console.ReadLine();

            double radius = Convert.ToDouble(str);

            double lengthCircle = TWO * Math.PI * radius;
            double areaCircle = Math.PI * Math.Pow(radius, TWO);

            Console.WriteLine($"Ответ:" +
                              $"\nдлина оркужности = {lengthCircle} \nплощадь окружности = {areaCircle}");

            // 3-задание
            Console.WriteLine("\nПеревод расстояние из сантиметров в метры:");
            Console.Write("Введите расстояние в сантиметрах: ");
            str = Console.ReadLine();

            const double HUNDRED = 100.0;

            double distance = Convert.ToInt32(str) / HUNDRED;

            Console.WriteLine($"Ответ:" +
                              $"\nрасстояние в метрах = {distance}");

            // 4-задание
            Console.WriteLine("\nПеревод дней в недели:");

            const int DAYS = 234;

            int weeks = DAYS / SEVEN;

            Console.WriteLine($"Ответ:" +
                              $"\nв 234 днях = {weeks} недель");

            // 5-задание
            Console.Write("\nВведите любое двузначное число: ");
            str = Console.ReadLine();

            const int TEN = 10;

            int number = Convert.ToInt32(str);

            int tens = number / TEN;
            int ones = number % TEN;
            int sum = tens + ones;
            int multiply = tens * ones;

            Console.WriteLine($"Ответ:" +
                              $"\nдесятки числа = {tens}" +
                              $"\nединицы числа = {ones}" +
                              $"\nсумма десятков и единиц = {sum}" +
                              $"\nпроизведение десятков и единиц = {multiply}");

            // 6-задание 
            Console.Write("\nВведите любое четырехзначное число: ");
            str = Console.ReadLine();

            number = Convert.ToInt32(str);

            int numberThousands = number % TEN; number /= TEN;
            int numberHundreds = number % TEN; number /= TEN;
            int numberTens = number % TEN; number /= TEN;
            int numberOnes = number % TEN;

            sum = numberThousands + numberHundreds + numberTens + numberOnes;
            multiply = numberThousands * numberHundreds * numberTens * numberOnes;

            Console.WriteLine($"Ответ:" +
                              $"\nсумма цифр четырехзначного числа = {sum} " +
                              $"\nпроизведение цифр четырехзначного числа = {multiply}");

            // 7-задание
            Console.WriteLine("\nЗадачка: ");
            Console.WriteLine("В трехзначном числе x зачеркнули его вторую цифру. " +
                             "\nКогда к образованному при этом двузначному числу " +
                             "\nсправа приписали вторую цифру числа x, то получилось число 456. " +
                             "\nНайти число x.");

            const int MAGIC_NUMBER = 456;

            number = MAGIC_NUMBER;

            string digitHundreds = ((int)(number / HUNDRED)).ToString();
            string digitTens = ((int)(number / TEN) % TEN).ToString();
            string digitOnes = ((int)(number % HUNDRED) % TEN).ToString();

            string firstNumber = digitHundreds + digitOnes + digitTens;

            Console.WriteLine($"Ответ:" +
                              $"\nИскомое число x = {firstNumber}");

            // 8-задание
            Console.WriteLine("\nУ нас есть логические переменные X и Y, необходимо найти логическое значение...");

            bool X = true;
            bool Y = true;

            Console.WriteLine($"При не Х и не У ; Ответ: {!X && !Y}," +
                              $"\nпри Х или (не Х и У) ; Ответ: {X || (!X && Y)}," +
                              $"\nпри (не Х и У) или У ; Ответ: {(!X && Y) || Y}");

            Console.ReadLine();
        }
    }
}
