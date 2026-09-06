using System;
//ENUNCIADO: 
//Crea una jerarquía de clases en la que Animal sea la clase base, Mamifero sea una clase
//intermedia y Perro sea una clase derivada. Asegúrate de que Perro herede los métodos de
//Mamifero y Animal, y sobrescriba el método HacerSonido().

namespace Ejercicio5
{
    class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido genérico.");
        }
    }

    // Se crea la clase intermedia que hereda de Animal
    class Mamifero : Animal
    {
        // Método exclusivo de los mamíferos
        public void Alimentar()
        {
            Console.WriteLine("El mamífero se está amamantando.");
        }
    }

    //  Clase derivada que hereda de Mamifero.
    class Perro : Mamifero
    {
        // Sobrescribimos el sonido específico del perro
        public override void HacerSonido()
        {
            Console.WriteLine("El perro hace: ¡Guau, guau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 5 ===");
            
            // Se Crea la instancia de Perro
            Perro miCachorro = new Perro();

            Console.WriteLine("\nLlamada al método sobrescrito:");
           //Método modificado en la clase perro. 
            miCachorro.HacerSonido();

            Console.WriteLine("\nLlamada al método heredado:");
            // Método que heredó de la clase intermedia Mamifero.
            miCachorro.Alimentar();
        }
    }
}