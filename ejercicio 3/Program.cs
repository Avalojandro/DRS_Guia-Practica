using System;

// Enunciado: Crea una clase base Vehiculo que tenga los métodos Arrancar() y Detener().
// Luego, crea una clase derivada Coche que herede de Vehiculo y añada un método Conducir().
// Asegúrate de que el Coche pueda usar los métodos heredados de Vehiculo y su propio método Conducir().

namespace Ejercicio3
{
    // Clase Vehiculo
    public class Vehiculo
    {
        // Arrancar
        public void Arrancar()
        {
            Console.WriteLine("El vehículo ha arrancado.");
        }

        // Detener
        public void Detener()
        {
            Console.WriteLine("El vehículo se ha detenido.");
        }
    }

    // Clase Coche que herede de Vehiculo
    public class Coche : Vehiculo
    {
        // Conducir
        public void Conducir()
        {
            Console.WriteLine("El coche está en movimiento (conduciendo).");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE VEHÍCULOS (HERENCIA SIMPLE) ===");

            // Coche
            Coche miCoche = new Coche();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Arrancar coche (método heredado de Vehiculo)");
                Console.WriteLine("2. Conducir coche (método propio de Coche)");
                Console.WriteLine("3. Detener coche (método heredado de Vehiculo)");
                Console.WriteLine("4. Ejecutar secuencia completa");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine();
                        miCoche.Arrancar();
                        break;

                    case "2":
                        Console.WriteLine();
                        miCoche.Conducir();
                        break;

                    case "3":
                        Console.WriteLine();
                        miCoche.Detener();
                        break;

                    case "4":
                        Console.WriteLine("\n--- Secuencia de Uso ---");
                        miCoche.Arrancar();
                        miCoche.Conducir();
                        miCoche.Detener();
                        break;

                    case "5":
                        salir = true;
                        Console.WriteLine("\n¡Programa finalizado!");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, selecciona una opción del 1 al 5.");
                        break;
                }
            }
        }
    }
}
