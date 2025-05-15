using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, p1, p2, p3, p4, m1, m2, m3, m4;
            double suma, mensualidad;

            Console.WriteLine("Ingresar la edad de Ana Paula");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la edad de Lucia");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la edad de Milena");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la edad de Jazmin");
            n4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el valor de la mensualidad");
            mensualidad = double.Parse(Console.ReadLine());

            suma = n1 + n2 + n3 + n4;

            p1 = n1 / suma;
            p2 = n2 / suma;
            p3 = n3 / suma;
            p4 = n4 / suma;

            m1 = p1 * mensualidad;
            m2 = p2 * mensualidad;
            m3 = p3 * mensualidad;
            m4 = p4 * mensualidad;

            Console.WriteLine("La mensualidad de Ana Paula es: " + m1 + " Pesos ");
            Console.WriteLine("La mensualidad de Lucia es: " + m2 + " Pesos ");
            Console.WriteLine("La mensualidad de Milena es: " + m3 + " Pesos ");
            Console.WriteLine("La mensualidad de Jazmin es: " + m4 + " Pesos ");
        }
    }
}
