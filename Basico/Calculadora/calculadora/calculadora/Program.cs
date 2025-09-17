using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resulado = 0;
            string operador;

            Console.WriteLine("Digite o numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seu numero é: " + n1);
        }
    }
}
