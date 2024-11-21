
using System;
using veterinaria;

namespace Veterinaria
{
    class Program
    {
        
        static Mascota[] mascotas = new Mascota[100];
        static Servicio[] servicios = new Servicio[100];
        static Boleta[] boletas = new Boleta[100];
        static int idServicios = 0;

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Menú Veterinaria");
                Console.WriteLine("1. Crear Servicio");
                Console.WriteLine("2. Eliminar Servicio");
                Console.WriteLine("3. Listar Servicios");
                Console.WriteLine("4. Crear Mascota");
                Console.WriteLine("5. Eliminar Mascota");
                Console.WriteLine("6. Listar Mascotas");
                Console.WriteLine("7. Crear Boleta");
                Console.WriteLine("8. Listar Boletas");
                Console.WriteLine("9. Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearServicio();
                        break;
                    case "2":
                        EliminarServicio();
                        break;
                    case "3":
                        ListarServicios();
                        break;
                    case "4":
                        //CrearMascota();
                        break;
                    case "5":
                        //EliminarMascota();
                        break;
                    case "6":
                        //ListarMascotas();
                        break;
                    case "7":
                        //CrearBoleta();
                        break;
                    case "8":
                        //ListarBoletas();
                        break;
                    case "9":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void CrearServicio()
        {
            Console.Write("Descripción del Servicio: ");
            string descripcion = Console.ReadLine();
            Console.Write("Precio del Servicio: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            if (idServicios < servicios.Length)
            {
                servicios[idServicios++] = new Servicio(descripcion, precio);
                Console.WriteLine("Servicio creado exitosamente.");
            }
            else
            {
                Console.WriteLine("No hay espacio para más servicios.");
            }
        }

        static void EliminarServicio()
        {
            Console.Write("Ingrese el código del servicio a eliminar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < idServicios; i++)
            {
                if (i == codigo)
                {
                    for (int j = i; j < idServicios - 1; j++)
                    {
                        servicios[j] = servicios[j + 1];
                    }
                    servicios[--idServicios] = null;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("Servicio eliminado.");
            }
            else
            {
                Console.WriteLine("Servicio no encontrado.");
            }
        }

        static void ListarServicios()
        {
            Console.WriteLine("Servicios:");
            for (int i = 0; i < idServicios; i++)
            {
                Console.WriteLine($"{i}. {servicios[i].Descripcion} - ${servicios[i].Precio}");
            }
        }
    }
}
