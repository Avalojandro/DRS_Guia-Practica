using System;

// Enunciado: Crea una clase Empleado que tenga dos atributos privados: nombre y edad.
// Implementa encapsulación para acceder a estos atributos a través de propiedades.
// Asegúrate de que la edad solo pueda ser modificada a través de un valor válido (mayor que 0 y menor que 100).

namespace Ejercicio2
{
    // Clase Empleado que aplica encapsulación
    public class Empleado
    {
        private string nombre;
        private int edad;

        // Nombre
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: El nombre no puede estar vacío.");
                    return;
                }
                nombre = value;
            }
        }

        // Edad
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0 && value < 100)
                {
                    edad = value;
                    Console.WriteLine($"Edad actualizada a {edad} años.");
                }
                else
                {
                    Console.WriteLine("Error: La edad debe ser mayor que 0 y menor que 100.");
                }
            }
        }

        // Constructor
        public Empleado(string nombreInicial, int edadInicial)
        {
            Nombre = nombreInicial;
            Edad = edadInicial;
        }

        // Mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine($"\n--- Datos del Empleado ---");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE EMPLEADOS ===");

            // Pedir datos iniciales
            Console.Write("\nIngresa el nombre del empleado: ");
            string nombreInput = Console.ReadLine();

            Console.Write("Ingresa la edad del empleado: ");
            int.TryParse(Console.ReadLine(), out int edadInput);

            // Crear empleado
            Empleado empleado = new Empleado(nombreInput, edadInput);

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Ver información del empleado");
                Console.WriteLine("2. Modificar nombre");
                Console.WriteLine("3. Modificar edad");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        empleado.MostrarInformacion();
                        break;

                    case "2":
                        Console.Write("\nIngresa el nuevo nombre: ");
                        string nuevoNombre = Console.ReadLine();
                        empleado.Nombre = nuevoNombre;
                        break;

                    case "3":
                        Console.Write("\nIngresa la nueva edad: ");
                        if (int.TryParse(Console.ReadLine(), out int nuevaEdad))
                        {
                            empleado.Edad = nuevaEdad;
                        }
                        else
                        {
                            Console.WriteLine("Error: Ingresa un número entero válido.");
                        }
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("\n¡Programa finalizado!");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, selecciona una opción del 1 al 4.");
                        break;
                }
            }
        }
    }
}
