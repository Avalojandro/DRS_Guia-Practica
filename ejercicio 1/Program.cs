using System;

// Enunciado: Crea una clase CuentaBancaria que represente una cuenta bancaria. Utiliza abstracción de
// datos para ocultar el detalle de la implementación del saldo y solo permite el acceso a través
// de los métodos públicos. Los métodos deben permitir realizar operaciones como depositar,
// retirar y consultar el saldo.

namespace Ejercicio1
{
    // Clase cuenta bancaria
    public class CuentaBancaria
    { 
        // Saldo
        private decimal saldo;

        // Constructor
        public CuentaBancaria(decimal saldoInicial = 0)
        {
            if (saldoInicial < 0)
            {
                Console.WriteLine("El saldo inicial no puede ser negativo.");
                saldo = 0;
            }
            else
            {
                saldo = saldoInicial;
            }
        }

        // Depositar dinero
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a depositar debe ser positivo.");
                return;
            }

            saldo += monto;
            Console.WriteLine($"Depósito de ${monto} realizado con éxito.");
        }

        // Retirar dinero
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a retirar debe ser positivo.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine($"Error: Fondos insuficientes. Intentaste retirar ${monto}, pero tu saldo es ${saldo}.");
                return;
            }

            saldo -= monto;
            Console.WriteLine($"Retiro de ${monto} realizado con éxito.");
        }

        // Consultar saldo actual
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cuenta bancaria (inicia con $0)
            CuentaBancaria cuenta = new CuentaBancaria(0);
            bool salir = false;

            Console.WriteLine("=== BIENVENIDO AL SISTEMA BANCARIO ===");

            while (!salir)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Depositar Dinero");
                Console.WriteLine("3. Retirar Dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"\nTu saldo actual es: ${cuenta.ObtenerSaldo()}");
                        break;

                    case "2":
                        Console.Write("\nIngresa el monto a depositar: $");
                        if (decimal.TryParse(Console.ReadLine(), out decimal montoDeposito))
                        {
                            cuenta.Depositar(montoDeposito);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Ingresa un número válido.");
                        }
                        break;

                    case "3":
                        Console.Write("\nIngresa el monto a retirar: $");
                        if (decimal.TryParse(Console.ReadLine(), out decimal montoRetiro))
                        {
                            cuenta.Retirar(montoRetiro);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Ingresa un número válido.");
                        }
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("\n¡Gracias por usar el sistema bancario! Hasta luego.");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, selecciona una opción del 1 al 4.");
                        break;
                }
            }
        }
    }
}


