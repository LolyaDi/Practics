using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FIVE = 5, TEN = 10, TWENTY_ONE = 21;
            string userStringValue;
            
            // 1-задание
            Console.WriteLine($"Вывод трех любых чисел: {FIVE}  {TEN}  {TWENTY_ONE}");

            // 2-задание
            Console.WriteLine($"\nВывод трех чисел(5 10 21), с перебрасыванием каретки:\n{FIVE}\n{TEN}\n{TWENTY_ONE}");

            // 3-задание
            Console.WriteLine("\nПеревод расстояние из сантиметров в метры:");
            Console.Write("Введите расстояние в сантиметрах: ");
            userStringValue = Console.ReadLine();

            const double HUNDRED = 100.0;

            double distanceInMetre = Convert.ToInt32(userStringValue) / HUNDRED;

            Console.WriteLine("Ответ:" +
                              $"\nрасстояние в метрах = {distanceInMetre}");

            // 4-задание
            Console.WriteLine("\nПеревод дней в недели:");

            const int SEVEN = 7, DAYS = 234;

            int weeks = DAYS / SEVEN;

            Console.WriteLine("Ответ:" +
                              $"\nв 234 днях = {weeks} недель");

            // 5-задание
            Console.Write("\nВведите любое двузначное число: ");
            userStringValue = Console.ReadLine();

            int twoDigitNumber = Convert.ToInt32(userStringValue);

            int tensOfNumber = twoDigitNumber / TEN;
            int onesOfNumber = twoDigitNumber % TEN;
            int sumOfTensAndOnes = tensOfNumber + onesOfNumber;
            int multiplyOfTensAndOnes = tensOfNumber * onesOfNumber;

            Console.WriteLine("Информация о числе:" +
                              $"\nдесятки числа = {tensOfNumber}" +
                              $"\nединицы числа = {onesOfNumber}" +
                              $"\nсумма десятков и единиц = {sumOfTensAndOnes}" +
                              $"\nпроизведение десятков и единиц = {multiplyOfTensAndOnes}");

            // 6-задание
            Console.WriteLine("\nИмеются такие логические величины как: A(истина), B(ложь), C(ложь). " +
                "\nНеобходимо вычислить значения следующих логических выражений: " +
                "\na) A || B" +
                "\nb) A && B" +
                "\nc) B || C");

            bool firstBoolValue = true, secondBoolValue = false, thirdBoolValue = false;

            Console.WriteLine("Ответ:" +
                              $"\na) {firstBoolValue || secondBoolValue}"+
                              $"\nb) {firstBoolValue && secondBoolValue}"+
                              $"\nc) {secondBoolValue || thirdBoolValue}");

            // 7-задание
            Console.Write("\nВведите радиус окружности для вычисления ее площади: ");
            userStringValue = Console.ReadLine();

            double radiusCircle = Convert.ToDouble(userStringValue);

            Console.Write("Введите сторону квадрата для вычисления его площади: ");
            userStringValue = Console.ReadLine();

            int squareSide = Convert.ToInt32(userStringValue);

            const int POWER_OF_NUMBER = 2;

            double circleArea = Math.PI * Math.Pow(radiusCircle, POWER_OF_NUMBER);
            double squareArea = Math.Pow(squareSide, POWER_OF_NUMBER);

            Console.WriteLine("\nПлощади объектов:" +
                              $"\nПлощадь круга = {circleArea}" +
                              $"\nПлощадь квадрата = {squareArea}");

            Console.WriteLine("\nОтвет:");
            if(circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
            else if(circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }
            else
            {
                Console.WriteLine("Площади между собой равны");
            }

            // 8-задание
            Console.WriteLine("\nВвод информации о первом теле для вычисления плотности его материала:");
            Console.Write("Введите объем первого тела: ");
            userStringValue = Console.ReadLine();

            double volumeFirstObject = Convert.ToDouble(userStringValue);

            Console.Write("Введите массу первого тела: ");
            userStringValue = Console.ReadLine();

            double massFirstObject = Convert.ToDouble(userStringValue);

            Console.WriteLine("\nВвод информации о втором теле для вычисления плотности его материала:");
            Console.Write("Введите объем второго тела: ");
            userStringValue = Console.ReadLine();

            double volumeSecondObject = Convert.ToDouble(userStringValue);

            Console.Write("Введите массу второго тела: ");
            userStringValue = Console.ReadLine();

            double massSecondObject = Convert.ToDouble(userStringValue);

            double densityFirstObject = massFirstObject / volumeFirstObject;
            double densitySecondObject = massSecondObject / volumeSecondObject;

            Console.WriteLine("\nПлотности материалов:" +
                              $"\nПлотность материала первого объекта = {densityFirstObject}" +
                              $"\nПлотность материала второго объекта = {densitySecondObject}");

            Console.WriteLine("\nОтвет:");
            if(densityFirstObject > densitySecondObject)
            {
                Console.WriteLine("Материал первого объекта плотнее, чем материал второго");
            }
            else if(densityFirstObject < densitySecondObject)
            {
                Console.WriteLine("Материал второго объекта плотнее, чем материал первого");
            }
            else
            {
                Console.WriteLine("Плотности материалов равны");
            }

            // 9-задание
            Console.WriteLine("\nВвод информации о первом участке электрической цепи для вычисление силы тока:");
            Console.Write("Введите сопротивление на первом участке электрической цепи: ");
            userStringValue = Console.ReadLine();

            double resistanceFirstPart = Convert.ToDouble(userStringValue);

            Console.Write("Введите напряжение на первом участке электрической цепи: ");
            userStringValue = Console.ReadLine();

            double voltageFirstPart = Convert.ToDouble(userStringValue);

            Console.WriteLine("\nВвод информации о втором участке электрической цепи для вычисление силы тока:");
            Console.Write("Введите сопротивление на втором участке электрической цепи: ");
            userStringValue = Console.ReadLine();

            double resistanceSecondPart = Convert.ToDouble(userStringValue);

            Console.Write("Введите напряжение на втором участке электрической цепи: ");
            userStringValue = Console.ReadLine();

            double voltageSecondPart = Convert.ToDouble(userStringValue);

            double amperageFirstPart = voltageFirstPart / resistanceFirstPart;
            double amperageSecondPart = voltageSecondPart / resistanceSecondPart;

            Console.WriteLine("\nСилы тока на обоих участках цепи:" +
                              $"\nСила тока на первом участке электрической цепи = {amperageFirstPart}" +
                              $"\nСила тока на втором участке электрической цепи = {amperageSecondPart}");

            Console.WriteLine("\nОтвет:");
            if(amperageFirstPart < amperageSecondPart)
            {
                Console.WriteLine("На первом участке электрической цепи протекает меньший ток");
            }
            else if(amperageFirstPart > amperageSecondPart)
            {
                Console.WriteLine("На втором участке электрической цепи протекает меньший ток");
            }
            else
            {
                Console.WriteLine("Силы тока на обоих участках электрической цепи равны между собой");
            }

            // 10-задание
            const int TWENTY = 20, THIRTY_FIVE = 35;

            Console.WriteLine("\nВывод целочисленных чисел от 20 до 35:");
            for(int i = TWENTY; i <= THIRTY_FIVE; i++)
            {
                Console.WriteLine(i);
            }

            int rangeEnd, rangeStart;

            Console.Write("\nВведите любое число больше 10: ");
            userStringValue = Console.ReadLine();

            rangeEnd = Convert.ToInt32(userStringValue);

            if (rangeEnd > TEN)
            {
                Console.WriteLine($"\nВывод квадратов целочисленных чисел от 10 до {rangeEnd}:");
                for (int i = TEN; i <= rangeEnd; i++)
                {
                    Console.WriteLine(Math.Pow(i, POWER_OF_NUMBER));
                }
            }
            else
            {
                Console.WriteLine("Ошибка, число меньше или равно 10!");
            }

            const int FIFTY = 50;

            Console.Write("\nВведите любое число меньше 50: ");
            userStringValue = Console.ReadLine();

            rangeStart = Convert.ToInt32(userStringValue);

            if(rangeStart < FIFTY)
            {
                Console.WriteLine($"\nВывод целочисленных чисел в третьей степени от {rangeStart} до 50:");
                for (int i = rangeStart; i <= FIFTY; i++)
                {
                    Console.WriteLine(Math.Pow(i, POWER_OF_NUMBER + 1));
                }
            }
            else
            {
                Console.WriteLine("Ошибка, число больше или равно 50!");
            }

            Console.Write("\nВведите любое число, которое будет являться началом выводимого диапозона чисел: ");
            userStringValue = Console.ReadLine();

            rangeStart = Convert.ToInt32(userStringValue);

            Console.Write("Введите любое число, которое будет являться концом выводимого диапозона чисел: ");
            userStringValue = Console.ReadLine();

            rangeEnd = Convert.ToInt32(userStringValue);

            if(rangeEnd > rangeStart)
            {
                Console.WriteLine($"\nВывод целочисленных чисел от {rangeStart} до {rangeEnd}:");
                for (int i = rangeStart; i <= rangeEnd; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Ошибка, указан неправильный диапозон!");
            }

            Console.ReadLine();
        }
    }
}
