using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico10
{
    class EjercicioBasico10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula letra del DNI dado el número");
            Boolean valido = false;
            Char[] letras = {'T','R','W','A','G','M','Y','F','P','D','X','B','N','J','Z','S','Q','V','H','L','C','K','E'};
            do
            {
                try
                {
                    Console.Write("Introduzca el número de DNI: ");
                    Int32 num_dni = Convert.ToInt32(Console.ReadLine());
                    if (num_dni > 0 && num_dni < 100000000)
                    {
                        valido = true;
                        Int32 posicion = num_dni % 23;
                        Console.WriteLine("El dni completo es: " + num_dni + letras[posicion]);
                    }
                    else
                    {
                        Console.WriteLine("Número no válido.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Formato no válido. " + e.Message);
                }
            } while (!valido);
        }
    }
}
