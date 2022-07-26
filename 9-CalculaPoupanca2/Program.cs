using System;

class Program 
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("\nExecuntando Projeto 11 - Calculo Poupança 2\n");

        double investimento = 1000.0;

        for(int mes = 1; mes <= 12; mes+=1)
        {
            investimento *= 1.005;
            Console.WriteLine("No mes " + mes + " você tem: R$" + investimento);
        }
        // int mes = 1;

        // while (mes <=12)
        // {
        //     investimento = investimento * 1.005;
        //     System.Console.WriteLine("No mes " + mes +" você tem: R$" + investimento);

        //     mes += 1;
        // }
        
        System.Console.WriteLine("\n Tecle enter para sair...");
        Console.ReadLine();
    }
}