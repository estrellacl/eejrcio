using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Fa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey(); //realizando detenimiento de consola
        }
        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();


            Console.Write("Ingrese su carrera:");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre},bienvenido al curso FA de {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"tella\"");
        }

        static void ejer3()
        {
            Console.WriteLine("Ingrese x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            double divi = (double)x / (double)y;

            Console.Write("\nSuma : " + (x + y));
            Console.Write("Resta : " + (x - y));
            Console.Write("Multi : " + (x * y));
            Console.Write("Divi : " + (x / y));
        }

        static void ejer4()
        {
            Console.Write("INGRESE UN NUMERO DECIMAL:");
             double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num, 0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num,1/3d);

            Console.WriteLine("raiz2:"  + raiz2 );
            Console.WriteLine("redondeando: " + redo);
            Console.WriteLine("Al cubo :" + cubo);
            Console.WriteLine("raiz3 :" + raiz3);
        }

        
        static void ejer5()
        {
            Console.Write("Ingrese un numero :");
            string num = Console.ReadLine();

            int entero = int.Parse(num);    
            double deci = double.Parse(num);

            Console.WriteLine("resto :" + entero % 2);
            Console.WriteLine("divi 3 :" + deci / 3);
        }


    }

}

