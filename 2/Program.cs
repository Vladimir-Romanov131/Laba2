using System;

namespace _2 {
    class Program {
        static void Main(string[] args) {
            int i;
            Console.WriteLine("Введите количество слагаемых");
            int x = int.Parse(Console.ReadLine());
            double z = 3; // знаменатель 
            double ch = 1; //числитель 
            for (i=0; i < x; i++) 
            {
                ch = ch - (1 / z) +( 1 / (z + 2)); // 3 + 2 + 2 + 2 ...x раз
                z = z + 4;
            }
            Console.WriteLine(ch*4);












        }
    }
}
