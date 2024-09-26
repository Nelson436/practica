using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carito carrito = new Carito();

            while (true)
            {
                Console.WriteLine("Selecciona el articulo (ingresa '0' para finalizar):");
                Catalogo.MostrarCatalogo();

                int artID = Convert.ToInt32(Console.ReadLine());

                if (artID == 0)
                {
                    break;
                }

                Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);

                if (articuloSeleccionado != null)
                {
                    carrito.AgregarArticulo(articuloSeleccionado);
                    Console.WriteLine($"Articulo '{articuloSeleccionado.Nombre}' agregado al carrito.");
                }
                else
                {

                }
            }
        }
    }
}