using System;

namespace CalculoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Executando Projeto 7 - Calculo de Poupança. \n");

            double investimento = 1000;
            //Rendimento de 0.5% ao mês

            int mes = 1;

            while (mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + mes + " você tem: " + investimento);
                
                mes++;
                // Também seria aceito como mes +=1 ;
            }



            Console.WriteLine("Tecle enter para sair.");
            Console.ReadLine();
        }
    }
}
