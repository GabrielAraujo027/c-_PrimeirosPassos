using System;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Condicionais");

            int idadeJoao = 16;
            int quantidadeAcompanahantes = 2;

            bool acompanhado = quantidadeAcompanahantes > 1;

            if(idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar!");
            } 
            else
            {
                Console.WriteLine("Não pode entrar!!!");
            }

            Console.WriteLine("Tecla enter para sair");
            Console.ReadLine();
        }
    }
}
