using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A soma do {num1} e {num2} é {num1 + num2}");
            Console.WriteLine($"A subitração do {num1} e {num2} é {num1 - num2}");
            Console.WriteLine($"A muntiplicação do {num1} e {num2} é {num1 * num2}");
            Console.WriteLine($"A divisão do {num1} e {num2} é {num1 / num2}");
        }  

    }
}
