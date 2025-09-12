using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_04_V_C_
{
    internal class EJER_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("MENOR DE EDAD");
            }
            else
            {
                if (edad > 18 && edad <= 64)
                {
                    Console.WriteLine("ADULTO");
                }
                else
                {
                    Console.WriteLine("ADULTO MAYOR");
                }
                {
                }
                Console.ReadKey();
            }
        }
    }
}
