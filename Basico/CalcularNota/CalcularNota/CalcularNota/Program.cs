using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            double nota1, nota2, resultado = 0;

            //Entrada de dados
            Console.WriteLine("Digite sua nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            //Calculo dos dados
            resultado = ((nota1 + nota2) / 2);

            //Saida de dados
            Console.WriteLine("Sua nota e: " + resultado);
        }
    }
}
