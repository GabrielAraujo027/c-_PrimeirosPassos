using System;

class Program 
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("\nExecuntando Projeto teste - Contador \n");

        // for (int contadorLinhas = 0; contadorLinhas < 100; contadorLinhas+=3)
        // {
        //     for(int contador = 0; contador < 100; contador+=3)
        //     {
        //         Console.Write(contador + "; ");
        //         if(contador >= contadorLinhas)
        //         {
        //             break;
        //         }
        //     }
        //     Console.WriteLine();
        // }


        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
        
        System.Console.WriteLine("\n Tecle enter para sair...");
        Console.ReadLine();
    }
}