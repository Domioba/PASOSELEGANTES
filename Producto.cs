using System;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public Image Imagen { get; set; } // Para mostrar la imagen del producto

        // Constructor para inicializar el producto
        public Producto(string nombre, double precio, string descripcion, Image imagen)
        {
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
            Imagen = imagen;
        }
    }
}
