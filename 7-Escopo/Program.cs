using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Condicionais");

            int idadeJoao = 16;
            int quantidadeAcompanahantes = 2;

            bool acompanhado = quantidadeAcompanahantes > 1;

            string textoAdicional;

            if(acompanhado)
            {
                textoAdicional = "João está acompanhado";
            }
            else
            {
                textoAdicional = "João não está acompanhado";
            }
            
            if(idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine(textoAdicional);
                Console.WriteLine("Seja bem vindo.");
            } 
            else
            {
                Console.WriteLine(textoAdicional);
                Console.WriteLine("Infelizmente, você não pode entrar.");
            }

            Console.WriteLine("Tecla enter para sair");
            Console.ReadLine();
        }
    }
}
