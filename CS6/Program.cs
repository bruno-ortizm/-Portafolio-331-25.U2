using System;
// Bruno Ortiz Melendez 331-25
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sesion 14 - CICLO FOR
            // Ciclo For :
            /*
            for (inizialicacion; expresion; iterador;)
            {}
            */

            for (int numero = 35; numero <= 41; numero++)
            {
                Console.WriteLine(numero);
            }

            // 1. Definir un ciclo for para la siguiente frecuencia: -33 al -39

            for (int n = -33; n >= -39; n--)
            {
                Console.WriteLine(n * -1);
            }

            for (int a = 9; a <= 15; a++)
            {
                if (a == 13)
                {

                }
                else
                {
                    Console.WriteLine($"a: {a}");
                }
            }

            int titulo = 0;
            int intervalo_paginas = 88;

            for (int pagina = 1; pagina <= 539; pagina++)
            {
                if (pagina > intervalo_paginas)
                {
                    Console.WriteLine($"Titulo: {titulo += 1}");
                    Console.WriteLine($"Pagina: {pagina}");

                    intervalo_paginas += 88;
                }

                else
                {
                    // Console.WriteLine($"Pagina: {pagina}");
                }
            }
        }
    }
}