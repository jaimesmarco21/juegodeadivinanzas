using System;
namespace JuegoDeAdivinanzas
{
    // Clase que representa el juego
    class Juego
    {
        private int numeroSecreto;
        private int intentos;

        // Constructor que inicializa el juego
        public Juego()
        {
            Random random = new Random();
            numeroSecreto = random.Next(1, 11); // Genera un número aleatorio entre 1 y 10
            intentos = 0;
        }

        // Método para comenzar el juego
        public void Comenzar()
        {
            Console.WriteLine("¡Bienvenido al juego de adivinanzas!");
            bool adivinado = false;

            // Ciclo principal del juego
            while (!adivinado)
            {
                Console.Write("Adivina un número entre 1 y 10: ");
                int numeroUsuario = int.Parse(Console.ReadLine());
                intentos++;

                // Evaluación de la adivinanza
                switch (numeroUsuario)
                {
                    case int n when n == numeroSecreto:
                        Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
                        adivinado = true;
                        break;
                    case int n when n < numeroSecreto:
                        Console.WriteLine("El número es mayor.¡Inténtalo de nuevo!");
                        break;
                    case int n when n > numeroSecreto:
                        Console.WriteLine("El número es menor.¡Inténtalo de nuevo!");
                        break;
                    default:
                        Console.WriteLine("Número no válido, por favor ingresa un número entre 1 y 10.");
                        break;

                }

            }

        }

    }
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego(); // Creación de un objeto delj uego
            juego.Comenzar(); // Inicia el juego
        }
    }
}