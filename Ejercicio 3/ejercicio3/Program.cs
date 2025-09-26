using System;

public class Program
{
    // Variable global para el número secreto
    public static int numeroSecreto;
    // Variable global para el contador de intentos
    public static int intentos = 0;

    // Método principal
    public static void Main(string[] args)
    {
        Random GeneradorAleatorio = new Random();
        numeroSecreto = GeneradorAleatorio.Next(1, 11); // Número entre 1 y 10
        Console.WriteLine("Bienvenido al juego de Adivina el Número!");
        Console.WriteLine("Estoy pensando en un número entre 1 y 10.");
        PedirAdivinanza();
    }

    // Método que pide al usuario que adivine
    public static void PedirAdivinanza()
    {
        int adivinanza;
        bool acertado = false;
        while (!acertado)
        {
            Console.Write("Introduce tu adivinanza: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out adivinanza))
            {
                if (adivinanza >= 1 && adivinanza <= 10)
                {
                    acertado = VerificarAdivinanza(adivinanza);
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número entre 1 y 10.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");
            }
        }
    }

    // Método que verifica la adivinanza, aumenta el contador y muestra mensajes
    public static bool VerificarAdivinanza(int adivinanza)
    {
        intentos++;
        if (adivinanza == numeroSecreto)
        {
            Console.WriteLine($"¡Correcto! Has adivinado el número en {intentos} intento(s).");
            return true;
        }
        else
        {
            Console.WriteLine("Incorrecto. Intenta de nuevo.");
            return false;
        }
    }
}
