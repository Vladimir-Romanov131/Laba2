using System;

namespace _4 {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Введите количество слагаемых ");
            double q = double.Parse(Console.ReadLine());
            while (q<=0){
                Console.WriteLine("количество слагаемых должно быть не меньше нуля");
                q = double.Parse(Console.ReadLine());
                
            }
        
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            double a = 1;
            double y = 1;
            y = (Math.Pow(x,2) / factorial(2)); //y это косинус 
            int i = 1;
            while(y>=q){

                a = i % 2 == 1 ? a - y : a + y; // если 1 истина выражение равно а - y или а + у
                i++;
                y = (Math.Pow(x, (2 * i)) / factorial(2 * i));
            }
            Console.WriteLine($"cos(x) =  {a}");
            Console.WriteLine($"Количество учтенных слагаемых: {i} ");
            Console.ReadKey();
            
        }
        public static double factorial(double i) { //ghh
        if (i == 0) {
            return 1;
        }
        else {
            return i * factorial(i - 1);
        }
    }


    }

    
}
