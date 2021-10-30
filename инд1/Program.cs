using System;
namespace инд1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Введите минуты");
            uint m = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            uint s = uint.Parse(Console.ReadLine());
            uint M;
            uint c;
            uint S;
            uint Ms = m * 60;
            uint a = Ms + s;
            c = a / 3600;
            m = (a - ( c * 3600)) / 60;
            s = (a - (c * 3600) - (m * 60));
            if(c<=9){
                if(m<=9 ){
                M = m;
                if(s<=9){
                    S = s;
                    Console.WriteLine($"0{c}:0{m}:0{s}");
                }
                else if(s>9){
                    S = s;
                    Console.WriteLine($"0{c}:0{m}:{s}");
                }             
            }
            else if (m>0){
                M = m;
                if(s<=9){
                    S = s;
                    Console.WriteLine($"0{c}:{m}:0{s}");
                }
                else if(s>9){
                    S = s;
                    Console.WriteLine($"0{c}:{m}:{s}");
                }
            }
            }
            else if(c>9 || c<=24){
                if(m<=9 ){
                M = m;
                if(s<=9){
                    S = s;
                    Console.WriteLine($"{c}:0{m}:0{s}");
                }
                else if(s>9){
                    S = s;
                    Console.WriteLine($"{c}:0{m}:{s}");
                }               
            }
            else if (m>0){
                M = m;
                if(s<=9){
                    S = s;
                    Console.WriteLine($"{c}:{m}:0{s}");
                }
                else if(s>9){
                    S = s;
                    Console.WriteLine($"{c}:{m}:{s}");
                }
            }
            }
        }
    }
}
