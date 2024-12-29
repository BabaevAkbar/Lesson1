using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Соообщение и возраст.
            string Message = "Hello";
            int Age = 28;

            Console.WriteLine($"Message: {Message} \nAge: {Age}");

            // Сообщение и возраст после изменении.
            Message = "Hello C#";
            Age = 26;
            Console.WriteLine($"Message: {Message} \nAge: {Age}");


            // Задача №1(Begin 15.)
            // Pi
            const double Pi = 3.14;
            // Площадь круга (S)
            double Square = 10;

            // Находим диаметр окружности (D) 
            double Diametr = Math.Sqrt((4 * Square)/Pi);

            // Находим длину окружности (L)
            double Length = Pi * Diametr;

            Console.WriteLine($"Площадь: {Square},\nДиаметр окружности: {Diametr},\nДлина окружности: {Length}");

            // Задача №2 (Begin 36)
            // Скорость первого автомобиля (км/ч).
            double SpeedFirstCar = 10;

            // Скорость второго автомобиля (км/ч).
            double SpeedSecondCar = 10;

            // Расстояние между ними (км).
            double Distance = 50;

            // Время после которого надо просчитать (час).
            double TimeDistance = 1;

            // Общий путь проделанное обоими автомобилями.
            double Path = TimeDistance * (SpeedFirstCar + SpeedSecondCar);

            // Находим расстояние между ними после TimeDistance времени
            double DistanceSecond = Distance + Path;

            Console.WriteLine($"Расстояние между автомобилями после {TimeDistance}часов составляет {DistanceSecond}км если первый автомобиль имеет скорость {SpeedFirstCar}км/ч а второй {SpeedSecondCar}км/ч.");


            // Задача №3 (Integer 23)
            int Second = 10660;
            
            // Часы в нвших секундах
            int HourInSecond = Second/60/60;

            // Оставшийся минуа после последнего часа
            int MinuteLastHour = (Second - (HourInSecond * 60 * 60)) / 60;

            Console.WriteLine($"{MinuteLastHour} целых минут прошло с начала последенего часа.");

            // Задача №4 (Integer 30)
            int Year = 1899;
            int Century = 0;

            if(Year % 100 == 0)
            {
                Century = Year / 100;
            }
            else if(Year % 100 != 0)
            {
                Century = Year / 100 + 1;
            }

            Console.WriteLine($"Номер столетия {Year} года равен {Century} век");
        }
    }
}