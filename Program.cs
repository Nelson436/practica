using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogo.LlenarCatalogo();
            int numeroCompra = 1;  // Inicializar contador de compras
            string opcion = "sí";  // Opción para realizar otra compra

            while (opcion == "sí" || opcion == "si")
            {
                Carrito carrito = new Carrito();
                Ticket ticket = new Ticket();

                while (true)
                {
                    Console.WriteLine("\nSelecciona el artículo (ingresa '0' para finalizar):");
                    Catalogo.MostrarCatalogo();

                    if (!int.TryParse(Console.ReadLine(), out int artID))
                    {
                        Console.WriteLine("Por favor ingresa un número válido.");
                        continue;
                    }

                    if (artID == 0) break;

                    Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);

                    if (articuloSeleccionado != null)
                    {
                        Console.WriteLine($"¿Cuántos '{articuloSeleccionado.Nombre}' desea agregar al carrito?");
                        if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                        {
                            articuloSeleccionado.Cantidad = cantidad;
                            carrito.AgregarArticulo(articuloSeleccionado);
                            Console.WriteLine($"Artículo '{articuloSeleccionado.Nombre}' agregado al carrito con cantidad {cantidad}.");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad no válida, por favor ingrese un número mayor a 0.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Artículo no encontrado.");
                    }
                }

                // Mostrar los artículos en el carrito
                carrito.MostrarArticulosEnCarrito();

                // Confirmar si desea proceder con la compra
                Console.WriteLine("\n¿Desea proceder con la compra? (Sí/No):");
                string respuesta = Console.ReadLine().Trim().ToLower();
                if (respuesta != "sí" && respuesta != "si")
                {
                    Console.WriteLine("Compra cancelada. Gracias por visitar la tienda.");
                    return;
                }

                // Calcular total y generar ticket
                decimal totalSinIVA = carrito.CalcularTotal();
                decimal iva = Math.Round(totalSinIVA * 0.16m, 2); // 16% de IVA, redondeado a 2 decimales

                Console.WriteLine($"\nTotal a pagar (sin IVA): {totalSinIVA:C2}");
                Console.WriteLine($"IVA (16%): {iva:C2}");
                decimal totalConIVA = totalSinIVA + iva;
                Console.WriteLine($"Total a pagar (con IVA): {totalConIVA:C2}");

                // Solicitar el monto pagado
                Console.WriteLine("Ingrese el monto con el que va a pagar:");
                decimal montoPagado;
                while (!decimal.TryParse(Console.ReadLine(), out montoPagado) || montoPagado < totalConIVA)
                {
                    Console.WriteLine("El monto pagado es insuficiente. Ingrese un monto mayor o igual al total.");
                }

                decimal cambio = montoPagado - totalConIVA;

                // Llenar detalles del ticket
                ticket.Lista = carrito.ObtenerArticulos();
                ticket.Total = totalSinIVA;
                ticket.IVA = iva;
                ticket.Pagado = montoPagado;
                ticket.Cambio = cambio;
                ticket.Fecha = DateTime.Now;
                ticket.NumCompra = numeroCompra;

                // Mostrar el ticket completo
                ticket.MostrarTicket();
                numeroCompra++;  // Incrementar el número de compra

                Console.WriteLine("Gracias por su compra.");

                // Preguntar si desea realizar otra compra
                Console.WriteLine("\n¿Desea realizar otra compra? (Sí/No):");
                opcion = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine("Gracias por visitar la tienda. Presione cualquier tecla para salir...");
            Console.ReadKey();  // Pausa hasta que el usuario presione una tecla
        }
    }
}