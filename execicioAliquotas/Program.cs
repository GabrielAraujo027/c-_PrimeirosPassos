using System;

namespace execicioAliquotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Sistema de calculo do IR\n");
        // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
        // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
        // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636
         
            Double salario = 4300.0;

            if(salario >= 1900.0 && salario <= 2800.0)
                {
                    Console.WriteLine(" Sua aliquota é de 7%");
                    Console.WriteLine(" Você pode deduzir até R$142.00");
                }
            if(salario >= 2800.01 && salario <= 3751.00)
                {
                Console.WriteLine(" Sua aliquota é de 15%");
                Console.WriteLine(" Você pode deduzir R$350.00");
                }
            if(salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine(" Sua aliquota é de 22.5%");
                Console.WriteLine(" Você pode deduzir R$636.00");
            }

            Console.WriteLine("\nTecle enter para sair...");
            Console.ReadLine();
            
        }
    }
}
