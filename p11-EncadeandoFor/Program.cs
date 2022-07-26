using System;

class Program 
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("\n Execuntando Projeto 13 - Encadeando For \n");

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinhas)
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        System.Console.WriteLine("\n Tecle enter para sair...");
        Console.ReadLine();
    }
}