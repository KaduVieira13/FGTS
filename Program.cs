using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal porcentual = 8;
            decimal fundoG;
            decimal valor;

            Console.WriteLine("---Cálculo de FGTS---");
            Console.Write("Digite o valor..: ");
            valor = Convert.ToDecimal(Console.ReadLine());
            fundoG = (valor/100) * porcentual;
            Console.Write($"Com base no seu salário de {valor:C}, seu FGTS é..: {fundoG:C2}");

        }
    }
}
