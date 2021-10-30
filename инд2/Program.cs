using System;

namespace инд2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            while(N <=0 || N>=10) {
                Console.WriteLine("Введите N. N  от 1 до 9");
                N = int.Parse(Console.ReadLine());

            }
            int n = N;
            int d;
            Console.WriteLine($"Все двузначные числа, кратные {N}:");
             while( n<=99 ){
                d = n / N;
                Console.WriteLine(n);
                n = n + N;

             }
        }
    }
}
