using System;

namespace _1 {
    class Program {
        static void Main(string[] args) {   
            Console.WriteLine("Решение уравнения: ax^2+bx+c=0");
            Console.WriteLine("Введите значения:");
            Console.WriteLine("a:");
            double a = double.Parse(Console.ReadLine());
            if (a == 0){
                while (a==0){
                    Console.WriteLine("a меньше или равно нулю/Введите переменную еще раз");
                     a = double.Parse(Console.ReadLine());
                    
                }


            }
            Console.WriteLine("b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            double c = double.Parse(Console.ReadLine());
            double d = (Math.Pow(b,2)-4*a*c);
            if(d==0){
                double x = -b / (2*a);
                Console.WriteLine($"x = {x}");
            }
            else if (d>0){
            double x1 = ((-b)+Math.Sqrt(d)) / (2*a);
            double x2 = ((-b)-Math.Sqrt(d)) / (2*a);
            if(x1>0){
                Console.WriteLine($"X1 = {x1}");
            }
            else{
                Console.WriteLine("X1 корней нет");
            }
            if(x2>0){
                Console.WriteLine($"X2 = {x2}");
            }
            else{
                Console.WriteLine("X2 корней нет");
            }

            }
            else{
                
            }
            
            

                

























                
            













        }
    }
}
