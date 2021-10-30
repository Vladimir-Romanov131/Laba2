using System;

namespace _3 {
    class Program {
        static void Main(string[] args) {
            double v0 = 0;
            double v1 = 1;
            while (v1 < 1000)
            {
                double v = v0 + v1;
                v0 = v1;
                v1 = v;
            }
            Console.WriteLine($"Первое четырехзначное число: {v1}");
            int collll = 0;
            while (v1 < 10000)
            {
                double v = v0 + v1;
                v0 = v1;
                v1 = v;
                collll++;
            }
            Console.WriteLine($"Количество четырехзначных чисел Фибоначчи: {collll}");







        }
    }
}
