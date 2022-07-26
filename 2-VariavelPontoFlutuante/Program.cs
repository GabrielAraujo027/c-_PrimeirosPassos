using System;

namespace variavelPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2 - Variáveis Ponto Flutuante");
            double salario;
            salario = 3500.50;

            double teste; //O teste consiste no c# devolver o resultado da divisão com a parte decimal.
            teste = 5 / 2;
            double testeCerto;
            testeCerto = 5.0 / 2;

            Console.WriteLine(salario); 
            Console.WriteLine("");

            Console.WriteLine("Mesmo a variável sendo double e a divisão tendo como resultado um número decimal, o valor resultante é um número inteiro: 5/2 = " + teste);
            Console.WriteLine("Aqui neste caso, foi avisado ao c# que o resultado era pra ser um número decimal: 5.0/2 = " + testeCerto);

            Console.WriteLine("Tecle enter para fechar...");

            Console.ReadLine();
        }
    }
}
