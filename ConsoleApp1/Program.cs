using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            byte n1 = 126;
            int n2 = 2147483647;
            long n3 = 2147483648L;
            float n4 = 4.5f;
            double n5 = 4.5;

            bool b = false;
            char c = 'V';
            //unicode table
            char d = '\u0056';
            string nome = "Vinicius";
            //tipo generico aceita qualquer valor
            object obj1 = "Carlos";
            object obj2 = 4.5f;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            //Automatico o minimo e o maximo, vale para qualquer tipo numérico;
            int min = int.MinValue;
            int max = int.MaxValue;

            Console.WriteLine("\n" + min);
            Console.WriteLine(max);

            decimal min1 = decimal.MinValue;
            decimal max1 = decimal.MaxValue;

            Console.WriteLine("\n" + min1);
            Console.WriteLine(max1);


        }
    }
}
