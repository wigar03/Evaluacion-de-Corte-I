using System;

class CajeroAutomatico
{
    // variable global
    static double saldo = 500;

    //deposito
    static void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"Has depositado {cantidad}. El saldo actual es: {saldo}.");
        }
        else
        {
            Console.WriteLine("No se puede depositar un monto negativo o cero.");
        }
    }

    //retiro
    static void Retirar(double cantidad)
    {
        if (cantidad > 0)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine($"Has retirado {cantidad}. El saldo actual es: {saldo}.");
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo para realizar el retiro.");
            }
        }
        else
        {
            Console.WriteLine("Cantidad inválida. No se puede retirar un monto negativo o cero.");
        }
    }

    //consultar saldo
    static void ConsultarSaldo()
    {
        Console.WriteLine($"El saldo actual es: {saldo}.");
    }

    //menu
    static void MostrarMenu()
    {
        while (true)
        {
            Console.WriteLine("\nCajero lafise");
            Console.WriteLine("1. Depositar dinero");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("4. Salir");
            
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("¿Cuánto dinero deseas depositar? ");
                double cantidad = Convert.ToDouble(Console.ReadLine());
                Depositar(cantidad);
            }
            else if (opcion == "2")
            {
                Console.Write("¿Cuánto dinero deseas retirar? ");
                double cantidad = Convert.ToDouble(Console.ReadLine());
                Retirar(cantidad);
            }
            else if (opcion == "3")
            {
                ConsultarSaldo();
            }
            else if (opcion == "4")
            {
                Console.WriteLine("GRacias");
                break;
            }
            else
            {
                Console.WriteLine("selecciona una opción válida.");
            }
        }
    }

    // Método principal
    static void Main(string[] args)
    {
        MostrarMenu();
    }
}

