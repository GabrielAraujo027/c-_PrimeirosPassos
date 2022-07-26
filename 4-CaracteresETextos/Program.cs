using System;

namespace caracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 4 - Caractéres e outros Textos");
            
            char letra = 'a';
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            char letra2 = (char)66;
            Console.WriteLine(letra2);

            char letra3 = (char)67;
            Console.WriteLine(letra3);

            char letra4 = (char)(86 + 1);
            Console.WriteLine(letra4);

            string vazia = " ";

            string primeiraFrase = @"Lista de  nomes dos estagiários de serviços/demandas:
- Gabriel Araújo
- Kevison
- Carlos.";
            Console.WriteLine(vazia);
            Console.WriteLine(primeiraFrase);
            
            Console.WriteLine("Aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
