using System;

namespace aplicativoDoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projeto 3 - Conversões e outros tipos");

            double salario = 3000.60;

            // int é uma variável que armazena até 32bits e sempre apaga tudo após a vírgula
            int salarioArredonado = (int)salario;

            // Long é uma variável que armazena até 64bits
            long x = 2000000000000000000;

            // short é uma variável que armazena até 16bits
            short y = 15000;

            // float assim como o double pega casas decimais, porém o double pode armazenar até 64bits e o float pode armazenar até 32bits
            float altura = 1.62f;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(altura);
            Console.WriteLine(salarioArredonado);
            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
