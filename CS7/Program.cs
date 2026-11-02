using System;

namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion num quince: Funciones

            /*
            funcion: bloque de instrucciones para realizar una tarea especifica, que se  ejecuta unicamente cuando es invocada

            Sintaxis:
            tipo_dato_devuelto identificacor_funcion(parametros)
            {
                Bloque de instrucciones
            }
            */

            string saludar(string persona)
            {
                Console.WriteLine($"Hola {persona}!");

                return persona;
            }

            saludar("Fruni");

            // Ejercitacion:
            // 1. Definir e invocar una funcion para imprimi nombre clave y salon.

            void darInformacion()
            {
                string salon = "331";
                string nombre = "BRUNO";
                string clave = "331-25";

                Console.WriteLine($"Salon: {salon}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Clave: {clave}");
            }

            darInformacion();

            string darInformacionParametros(string salon, string nombre, string clave)
            {
                Console.WriteLine($"Salon: {salon}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Clave: {clave}");

                return salon;
                return nombre;
                return clave;
            }

            darInformacionParametros("331", "Prueba", "331-25");

            // 2. Definir e invocar una funcion para desplegar el horario de hoy, sin parametros.

            void pedirHorario()
            {
                Console.WriteLine("Horario:");
                Console.WriteLine("7:00-7:45 - CALC");
                Console.WriteLine("7:50-8:35 - FH");
                Console.WriteLine("8:40-9:30 - PROG");
                Console.WriteLine("9:50-10:35 - PSIC");
                Console.WriteLine("10:40-11:30 - Portugues");
                Console.WriteLine("11:50-12:35 - DIBT");
                Console.WriteLine("12:40-1:30 - DIBT");
            }
        }
    }
}