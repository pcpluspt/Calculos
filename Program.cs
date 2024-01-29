using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Aritmetica;
using static Calculos.Conversoes;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4, 2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");

            double t1 = Aritmetica.ConverterTemperatura(Aritmetica.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = Aritmetica.ConverterTemperatura(Aritmetica.ConversaoTemperatura.FahrenheitCelsius, 100);

            Console.WriteLine($"36º Celsius = {t1}º Fahrenheit");
            Console.WriteLine($"100º Fahrenheit = {t2}º Celsius");

            Console.ReadKey();
        }
    }
}
