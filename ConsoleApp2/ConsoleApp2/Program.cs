using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {

            //Faz quebra de linha
            Console.WriteLine("Pulando linha");
            //Não faz quebra de linha
            Console.Write(" - ");
            Console.WriteLine("Não pula linha ");

            double d = 256.156;

            //Para apresentar apenas duas casas decimais
            Console.WriteLine(d.ToString("F2"));

            //Evitar diversos Console.Write com tres formas
            int idade = 23;
            double saldo = 526.26;
            string nome = "Vinicius";

            //por tipo numerado {0}...
            Console.WriteLine("{0} tem {1} anos e tem saldo R$ {2:F2}", nome, idade, saldo);

            //por valor da variavel usando $ {}
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo R$ {saldo:F2}");

            //por concatenação de string e variaveis ""+variavel+""
            Console.WriteLine(nome + " tem "+ idade + " anos e tem saldo R$ "+ saldo.ToString("F2"));

        }
    }
}
