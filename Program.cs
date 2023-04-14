using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;  
            double n4;
            double Media;

            Console.Write("Insira o valor do Primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do Segundo numero: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do Terceiro numero: ");
            n3 = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do Quarto numero: ");
            n4 = double.Parse(Console.ReadLine());

            Media = (n1 + n2 + n3 + n4)/4;

            Console.WriteLine("A média aritmética é {0}.", Media);
        }
    }
}
