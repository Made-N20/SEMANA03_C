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
            ejer5();
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

        static void ejer3()
        {

            Console.Write("INGRESE X:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("ingrese y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            double divi = (double)x / (double)y;

            Console.WriteLine("\nSUMA:" + sum);
            Console.WriteLine("RESTA:" + (x - y));
            Console.WriteLine("MULTIPLICACION:" + (x * y));
            Console.WriteLine("DIVISION:" + (x / y));
        }
        static void ejer4()
        {

            Console.WriteLine("-------OPERACIONE--------: ");
            Console.Write("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num, 0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1 / 3);

            Console.WriteLine("raiz cuadrada2: " + raiz2);
            Console.WriteLine("redondeado: " + redo);
            Console.WriteLine("al cubo 3 :" + cubo);
            Console.WriteLine("raiz cubica: " + raiz3);

        }
        static void ejer5()
        {
            Console.Write("INGRESE UN NUMERO: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine(" resto: " + entero % 2);
            Console.WriteLine(" divi 3: " + deci / 3);
        }
      

    }
}    
