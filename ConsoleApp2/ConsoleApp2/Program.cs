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

            Console.WriteLine("\n\n\n\n");

            //Exercicio Fixação

            string s1 = "Computador";
            string s2 = "Mesa de escritorio";

            byte anos = 23;
            int codigo = 5290;
            char genero = 'M';

            double p1 = 2100.0;
            double p2 = 650.0;
            double p3 = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{s1}, cujo preço R$ {p1:F2}");
            Console.WriteLine("{0}, cujo preço R$ {1:F2}\n", s2, p2);
            Console.WriteLine("Registro: " + anos + " anos, codigo: " + codigo + " e genero: " + genero + "\n");
            Console.WriteLine("Medida com oito casas decimais: " + p3.ToString("F8"));
            Console.WriteLine("Arrendondado com tres casas: " + p3.ToString("F3"));

        }
    }
}
