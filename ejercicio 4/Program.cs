using System;
//ENUNCIADO: 

//Crea una clase base Animal con un método HacerSonido(). Luego, crea dos clases derivadas:
//Perro y Gato, que sobrescriban el método HacerSonido() para hacer un sonido diferente.
//Utiliza una referencia de tipo Animal para llamar al método HacerSonido() y demostrar el
//polimorfismo.

namespace Ejercicio4
{
    class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido genérico.");
        }
    }

    // Se defne la clase Perro que hereda de Animal
    class Perro : Animal
    {
            public override void HacerSonido()
        {
            Console.WriteLine("El perro hace: ¡Guau, guau!");
        }
    }

    // Se Define la clase Gato que hereda de Animal
    class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato hace: ¡Miau, miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 4 ===");
            
            // Se Crea las instancias de Perro y Gato
            Animal miPerro = new Perro();
            Animal miGato = new Gato();

           
            Console.WriteLine("\nDemostración de Polimorfismo:");
            
            // Llamamos al método. 
            miPerro.HacerSonido();
            miGato.HacerSonido();
        }
    }
}