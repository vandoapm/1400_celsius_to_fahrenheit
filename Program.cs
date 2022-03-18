using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1400_celsius_to_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Converter temperatura medida em graus Celsius Fahrenheit");

            Console.WriteLine();

            Console.Write("Digite a temperatura em ºC: ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine("A temperatura de "+c+"ºC é igual a "+ (9 * c + 160) / 5 + "ºF");

            Console.ReadLine();

        }
    }
}
