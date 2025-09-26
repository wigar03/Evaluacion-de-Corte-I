using System;
using System.Collections.Generic;

namespace ejercicio2
{
    class Program
    {
        // Diccionario para almacenar productos y sus cantidades
        static Dictionary<string, int> inventario = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar productos");
                Console.WriteLine("2. Retirar productos");
                Console.WriteLine("3. Consultar inventario");
                Console.WriteLine("4. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarProductos();
                        break;
                    case "2":
                        RetirarProductos();
                        break;
                    case "3":
                        ConsultarInventario();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        // Método para agregar productos al inventario
        static void AgregarProductos()
        {
            Console.Write("Ingrese el nombre del producto a agregar: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad de productos a agregar: ");
            int cantidad;
            if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
            {
                if (inventario.ContainsKey(nombre))
                {
                    inventario[nombre] += cantidad;
                }
                else
                {
                    inventario[nombre] = cantidad;
                }
                Console.WriteLine($"{cantidad} unidades de '{nombre}' agregadas. Total en inventario: {inventario[nombre]}");
            }
            else
            {
                Console.WriteLine("Cantidad no válida. Intente de nuevo.");
            }
        }

        // Método para retirar productos del inventario
        static void RetirarProductos()
        {
            Console.Write("Ingrese el nombre del producto a retirar: ");
            string nombre = Console.ReadLine();
            if (inventario.ContainsKey(nombre))
            {
                Console.Write("Ingrese la cantidad de productos a retirar: ");
                int cantidad;
                if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
                {
                    if (cantidad <= inventario[nombre])
                    {
                        inventario[nombre] -= cantidad;
                        Console.WriteLine($"{cantidad} unidades de '{nombre}' retiradas. Total en inventario: {inventario[nombre]}");
                        if (inventario[nombre] == 0)
                        {
                            inventario.Remove(nombre);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay suficientes productos en inventario.");
                    }
                }
                else
                {
                    Console.WriteLine("Cantidad no válida. Intente de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
        }

        // Método para consultar el inventario actual
        static void ConsultarInventario()
        {
            Console.WriteLine("Inventario actual:");
            if (inventario.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
            }
            else
            {
                foreach (var item in inventario)
                {
                    Console.WriteLine($"Producto: {item.Key}, Cantidad: {item.Value}");
                }
            }
        }
    }
}