using System;

namespace CS5 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // UNIDAD 1: Estructuras de Control II
            // UNIDAD 2: Funciones II

            // SESIÓN 12: Instrucción While

            /*SINTAXIS
            */

            int i = 1;

            while (i <= 10) {
                Console.WriteLine($"Iterador {i}");
                i++;
            }


            // EJERCITACION

            int m = 1;

            while (m < 6) {
                Console.WriteLine($"Rodrigo Franza");
                m++;
            }

            int d = 10;

            while (d > 0) {
                Console.WriteLine(d);
                d--;
            }

            // SECUENCIA

            int s = 3;

            while (s <= 18) {
                Console.WriteLine($"Numero: {s}");
                s += 3;
            }

            int a = 16;


            while (a >= 1) {
                Console.WriteLine("331");
                a -= 2;
            }

            /*
            Actividadd 1: Ciclo infinito

            1. Definir un ciclo infinito ascendente.
            2. Definir un ciclo infinito descendente.
            NOTA: Utilizar el operador de diferencia
            */

            // DESCENDIENTE

            int it2 = 99;

            while (it2 != 100) {
                Console.WriteLine(it2);
                it2--;

            
            }

            // ASCENDIENTE

            int it1 = 1;

            while (it1 > 0) {
                Console.WriteLine(it1);
                it1++;
            }
        }
    }
}