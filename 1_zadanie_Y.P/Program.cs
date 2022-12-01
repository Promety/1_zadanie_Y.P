using System;

namespace _1_zadanie_Y.P
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычисление гипотенузы по двум катетам!
            Console.WriteLine("Введите первый катет ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                Console.WriteLine("Катет не может быть отрицательным!");
            Console.WriteLine("Введите второй катет ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b) || b <= 0) 
                Console.WriteLine("Катет не может быть отрицательным!");
            double c;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Гипотенуза равна {0}", c);
        }
    }
}
