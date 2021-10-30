using System;

namespace инд1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Введите минуты");
            uint m = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            uint s = uint.Parse(Console.ReadLine());
            uint M;
            uint S;
            if(m<=9 ){
                M = m;
                if(s<=9){
                    S = s;
                    Console.WriteLine($"0{m}:0{s}");
                }
                else if(s>9){
                    S = s;
                    Console.WriteLine($"0{m}:{s}");

                }
                
                
            }
            else if (m>0){
                M = m;
                if(s<=9){
                    S = s;
                    Console.WriteLine($"{m}:0{s}");
                }
                else if(s>9){
                    S = s;
                    Console.WriteLine($"{m}:{s}");

                }

            }
        }
    }
}
