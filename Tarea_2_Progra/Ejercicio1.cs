using System;

namespace Tarea_2_Progra
{
    public class Ejercicio1
    {
        static void Main()
        {
            byte edad;

            Console.Write("Ingresa tu edad: ");
            edad = byte.Parse(Console.ReadLine());

            Console.WriteLine("Wow, no aparentas "+edad+" años");
        }
    }
}
