using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double masak, masag, cb, masasob, paquetes, cajas;

            Console.WriteLine("Ingresar cantidad de masa en kilogramos");
            masak = double.Parse(Console.ReadLine());

            masag = masak * 1000;
            cb = Math.Truncate(masag / 55);
            masasob = masag % 55;
            paquetes = Math.Truncate(cb /12);
            cajas = Math.Truncate(paquetes / 20);

            Console.WriteLine(cb +" Budines preparados");
            Console.WriteLine(masasob +" Gramos de masa sobrante");
            Console.WriteLine(paquetes +" Paquetes terminados");
            Console.WriteLine(cajas +" Cajas completadas");
        }
    }
}
