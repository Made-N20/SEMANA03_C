using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey(); // Realizando detenimiento de comsola

        }

        static void ejer1()
        {
            String nombre, carrera; 

            Console.Write("INGRESE SU NOMBRE:");
            nombre = Console.ReadLine();

            Console.Write("INGRESE SU CARRERA:");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n TU NOMBRE ES {nombre} BIENVENIDO A TU PRIMERA CLASE DE {carrera}");

        }

        static void ejer2()
        {
            Console.WriteLine("\"Madeleine\"");
        }
    }
}
