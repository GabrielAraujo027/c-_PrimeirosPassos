using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("\nExecuntando Projeto 12 - Investindo a longo prazo\n");

        double investimento = 1000.0;
        double fatorRendimento = 1.005;

        int ano = 1;

        while (ano <= 5)
        {
            Console.WriteLine("No ano " + ano + ":");
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
                Console.WriteLine("No mes " + mes + " você tem: R$" + investimento);
            }
            Console.WriteLine("\n");
            fatorRendimento += 0.001;
            ano++;
        }

        Console.WriteLine("Depois de 5 anos você terá: " + investimento);

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}