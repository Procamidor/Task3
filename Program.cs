using System;
using System.Reflection;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            int x = 10, y = 12, z = 3;
            Console.WriteLine("Операция №1 = {0}", x += y - x++ * z);

            x = 10; y = 12; z = 3;
            Console.WriteLine("Операция №2 = {0}", z = --x - y * 5);

            x = 10; y = 12; z = 3;
            Console.WriteLine("Операция №3 = {0}", y /= x + 5 % z);

            x = 10; y = 12; z = 3;
            Console.WriteLine("Операция №4 = {0}", z = x++ + y * 5);

            x = 10; y = 12; z = 3;
            Console.WriteLine("Операция №5 = {0}", x = y - x++ * z);

            //Задание 2
            int a = 4, b = 5, c = 6;
            int midleAmmounmt = (a + b + c) / 3;
            Console.WriteLine("Среднее арифметическое a, b, c = {0}", midleAmmounmt);

            //Задание 3
            const double pi = 3.1415926535897932384626433832795;
            int r = 16;
            double koren = Math.Pow(r, 2);
            Console.WriteLine("Площадь круга = {0}", pi * koren);
            //OR
            Console.WriteLine("Площадь круга = {0}", pi * Math.Pow(r, 2));

            //Задание 4
            
            Console.WriteLine("Введите радиус цилиндра ");
            int rad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Площадь цилиндра равно {0}", 2*pi*rad * (rad + h));
            Console.WriteLine("Объем цилиндра равен {0}", pi * Math.Pow(rad, 2)*h);

            //Задание 5
            //string uberflu? , _Identifier, \u006fIdentifier, &myVar , myVariab1le;
            Console.WriteLine(" uberflu? - нельзя; \n _Identifier - можно; \n \u006fIdentifier - можно; \n &myVar - нельзя; \n myVariab1le - нельзя.");

            Console.ReadLine();




        }
    }
}
