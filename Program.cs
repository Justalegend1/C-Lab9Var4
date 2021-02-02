using System;

namespace Lab9Var4
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ShowSquare1(double a, double b, double c, Triangle t)
            {
                double Sq;
                double p;
                p = (t.a + t.b + t.c) / 2;
                Sq = Math.Sqrt(p * (p - t.a) * (p - t.b) * (p - t.c));
                Console.WriteLine($"Площадь треугольника равна {Sq}");
            }
            static void Sushest(double a, double b, double c, Triangle t)
            {
                int k = 0;
                if ((t.a + t.b < t.c) | (t.b + t.c < t.a) | (t.c + t.a < t.b))
                {
                    Console.WriteLine("Такого треугольника не существует");
                    k++;
                }
                else
                {
                    int vibor;
                    Console.WriteLine("Статическая функция - 1\nМетод класса - 2");
                    bool o = Int32.TryParse(Console.ReadLine(), out vibor);
                    while (!o)
                    {
                        Console.WriteLine("Введите числовое значение");
                        o = Int32.TryParse(Console.ReadLine(), out vibor);
                    }
                    while ((vibor > 2) | (vibor < 1))
                    {
                        Console.WriteLine("Выберите значение от 1 до 2");
                        o = Int32.TryParse(Console.ReadLine(), out vibor);
                    }
                    switch (vibor)
                    {
                        case 1:
                            ShowSquare1(t.a, t.b, t.c, t);
                            break;
                        case 2:
                            t.ShowSquare2(t.a, t.b, t.c);
                            break;
                    }
                }

            }
            int number;
            Console.WriteLine("Выберите номер задания");
            bool o = Int32.TryParse(Console.ReadLine(), out number);
            while (!o)
            {
                Console.WriteLine("Введите целое число от 1 до 3");
                o = Int32.TryParse(Console.ReadLine(), out number);
            }
            while ((number < 1) | (number > 3))
            {
                Console.WriteLine("Введите число от 1 до 3");
                o = Int32.TryParse(Console.ReadLine(), out number);
            }
            Triangle t = new Triangle();
            switch (number)
            {
                case 1:
                    t.A = 1;
                    t.B = 1;
                    t.C = 1;
                    t.Show();
                    Sushest(t.a, t.b, t.c, t);
                    Console.WriteLine($"Количество созданных в классе объектов равно {Triangle.count}");
                    Console.ReadKey();
                    break;
                case 2:
                    Triangle k = new Triangle();
                    t.A = 1;
                    t.B = 1;
                    t.C = 1;
                    t.Show();
                    Sushest(t.a, t.b, t.c, t);
                    t++;
                    t.Show();
                    t--;
                    t.Show();
                    double s = (double)t;
                    t.SQ1 = 1;
                    Triangle t1 = new Triangle();
                    t1.A = 1;
                    t1.B = 1;
                    t1.C = 1;
                    t1.Show();
                    Sushest(t1.a, t1.b, t1.c, t1);
                    t1.SQ1 = 1;
                    Console.ReadKey();
                    bool result = t.Sq1 <= t1.Sq1;
                    if (result)
                        Console.WriteLine("Площадь первого треугольника меньше либо равна площади второго треугольника");
                    else Console.WriteLine("Площадь первого треугольника больше площади второго треугольника");
                    break;
            }

        }
    }
}
