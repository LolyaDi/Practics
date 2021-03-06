﻿using System;
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
            Console.Write("Для вычисления функции y = 7x^2-3x+4, введите любое число х: ");
            string userStringValue = Console.ReadLine();

            const int SEVEN = 7, THREE = 3, FOUR = 4, TWO = 2;

            int xValueOfMathFunction = Convert.ToInt32(userStringValue);

            int yValueOfMathFunction = (int)(SEVEN * Math.Pow(xValueOfMathFunction, TWO)) - (THREE * xValueOfMathFunction) + FOUR;

            Console.WriteLine($"Ответ:" +
                              $"\ny = {yValueOfMathFunction}");

            // 2-задание
            Console.Write("\nВведите радиус окружности для вычисления длины и площади круга: ");
            userStringValue = Console.ReadLine();

            double radiusCircle = Convert.ToDouble(userStringValue);

            double lengthCircle = TWO * Math.PI * radiusCircle;
            double areaCircle = Math.PI * Math.Pow(radiusCircle, TWO);

            Console.WriteLine($"Ответ:" +
                              $"\nдлина оркужности = {lengthCircle} \nплощадь окружности = {areaCircle}");

            // 3-задание
            Console.WriteLine("\nПеревод расстояние из сантиметров в метры:");
            Console.Write("Введите расстояние в сантиметрах: ");
            userStringValue = Console.ReadLine();

            const double HUNDRED = 100.0;

            double distanceInMetre = Convert.ToInt32(userStringValue) / HUNDRED;

            Console.WriteLine($"Ответ:" +
                              $"\nрасстояние в метрах = {distanceInMetre}");

            // 4-задание
            Console.WriteLine("\nПеревод дней в недели:");

            const int DAYS = 234;

            int weeks = DAYS / SEVEN;

            Console.WriteLine($"Ответ:" +
                              $"\nв 234 днях = {weeks} недель");

            // 5-задание
            Console.Write("\nВведите любое двузначное число: ");
            userStringValue = Console.ReadLine();

            int number, tensOfNumber, onesOfNumber, sumOfNumbersDigits, multiplyOfNumbersDigits;

            const int TEN = 10;

            number = Convert.ToInt32(userStringValue);

            tensOfNumber = number / TEN;
            onesOfNumber = number % TEN;
            sumOfNumbersDigits = tensOfNumber + onesOfNumber;
            multiplyOfNumbersDigits = tensOfNumber * onesOfNumber;

            Console.WriteLine($"Информация о числе:" +
                              $"\nдесятки числа = {tensOfNumber}" +
                              $"\nединицы числа = {onesOfNumber}" +
                              $"\nсумма десятков и единиц = {sumOfNumbersDigits}" +
                              $"\nпроизведение десятков и единиц = {multiplyOfNumbersDigits}");

            // 6-задание 
            Console.Write("\nВведите любое четырехзначное число: ");
            userStringValue = Console.ReadLine();

            number = Convert.ToInt32(userStringValue);

            int numberThousands = number % TEN; number /= TEN;
            int numberHundreds = number % TEN; number /= TEN;
            tensOfNumber = number % TEN; number /= TEN;
            onesOfNumber = number % TEN;

            sumOfNumbersDigits = numberThousands + numberHundreds + tensOfNumber + onesOfNumber;
            multiplyOfNumbersDigits = numberThousands * numberHundreds * tensOfNumber * onesOfNumber;

            Console.WriteLine($"Ответ:" +
                              $"\nсумма цифр четырехзначного числа = {sumOfNumbersDigits} " +
                              $"\nпроизведение цифр четырехзначного числа = {multiplyOfNumbersDigits}");

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

            bool firstBoolValue = true;
            bool secondBoolValue = true;

            Console.WriteLine($"При не Х и не У ; Ответ: {!firstBoolValue && !secondBoolValue}," +
                              $"\nпри Х или (не Х и У) ; Ответ: {firstBoolValue || (!firstBoolValue && secondBoolValue)}," +
                              $"\nпри (не Х и У) или У ; Ответ: {(!firstBoolValue && secondBoolValue) || secondBoolValue}");

            Console.ReadLine();
        }
    }
}
