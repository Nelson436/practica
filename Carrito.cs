using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_3
{
    internal class Carrito
    {
        private List<Articulo> articulosEnCarrito = new List<Articulo>();

        public void AgregarArticulo(Articulo articulo)
        {
            // Verificar si el artículo ya existe en el carrito para aumentar la cantidad
            var articuloExistente = articulosEnCarrito.Find(a => a.ID == articulo.ID);
            if (articuloExistente != null)
            {
                articuloExistente.Cantidad += articulo.Cantidad;  // Aumentar la cantidad según lo especificado
            }
            else
            {
                // Clonar el artículo para evitar cambiar el catálogo
                var nuevoArticulo = new Articulo
                {
                    ID = articulo.ID,
                    Nombre = articulo.Nombre,
                    Precio = articulo.Precio,
                    Cantidad = articulo.Cantidad
                };
                articulosEnCarrito.Add(nuevoArticulo);
            }
        }

        public List<Articulo> ObtenerArticulos()
        {
            return articulosEnCarrito;
        }

        public void MostrarArticulosEnCarrito()
        {
            Console.WriteLine("\n--- Artículos en el Carrito ---");
            if (articulosEnCarrito.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
            }
            else
            {
                foreach (var articulo in articulosEnCarrito)
                {
                    Console.WriteLine($"ID: {articulo.ID}, Nombre: {articulo.Nombre}, Cantidad: {articulo.Cantidad}, Precio Unitario: {articulo.Precio:C2}, Subtotal: {articulo.CalcularSubtotal():C2}");
                }
            }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var articulo in articulosEnCarrito)
            {
                total += articulo.CalcularSubtotal();  // Calcular el total basado en el subtotal de cada artículo
            }
            return total;
        }

        public void VaciarCarrito()
        {
            articulosEnCarrito.Clear();  // Vaciar el carrito para la siguiente compra
        }
    }
}