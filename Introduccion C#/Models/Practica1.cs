using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion_C_.Models
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            // int, string, bool, double, char

            int cal1 = 0;
            int cal2, suma;
            string dato1;

            // Pedir primera calificación
            Console.WriteLine("Ingresa primera calificacion: ");
            dato1 = Console.ReadLine();
            cal1 = Convert.ToInt32(dato1);

            // Pedir segunda calificación
            Console.WriteLine("Ingresa segunda calificacion: ");
            dato1 = Console.ReadLine();
            cal2 = Convert.ToInt32(dato1);

            // Suma
            suma = cal1 + cal2;
            Console.WriteLine("La suma de las calificaciones es: " + suma);

            // if-else
            if (cal1 > cal2)
            {
                Console.WriteLine("La nota mayor es: " + cal1);
            }
            else if (cal2 > cal1)
            {
                Console.WriteLine("La nota mayor es: " + cal2);
            }
            else
            {
                Console.WriteLine("Las dos calificaciones son iguales");
            }

            // While
            int x = 1;

            Console.WriteLine("\nWhile:");

            while (x <= 10)
            {
                Console.Write(x);
                Console.Write(" - ");
                x++;
            }

            // do while
            int y = 1;

            Console.WriteLine("\n\nDo While:");

            do
            {
                Console.Write(y);
                Console.Write(" - ");
                y++;
            } while (y <= 10);

            // For
            Console.WriteLine("\n\nFor:");

            for (int f = 0; f <= 10; f++)
            {
                Console.Write(f);
                Console.Write(" - ");
            }

            Console.WriteLine("\n\nFin del programa");
        }
    }
}