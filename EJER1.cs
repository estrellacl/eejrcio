using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class EJER1
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE SU EDAD :");
            int edad= int.Parse(Console.ReadLine());

            if(edad < 18)
            {
                Console.WriteLine("MENOR DE EDAD");

            }
            else
            {
                if (edad >= 18 && edad <= 64) 
                {
                    Console.WriteLine("ADULTO");
                }
                else
                {
                    Console.WriteLine("ADULTO MAYOR");

                }

                Console.ReadKey();
            }


            
        }
    }
}
