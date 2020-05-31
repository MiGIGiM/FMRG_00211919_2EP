using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
        //corrección: cambio de acceso
        public string idArticulo { get; }
        //corrección: cambio de acceso
        public string producto { get; }
        //corrección: cambio de acceso
        public string descripcion { get; }
        //corrección: cambio de acceso
        public string precio { get; }
        //corrección: cambio de acceso
        public string stock { get; }

        public Inventario(string idArticulo, string producto, string descripcion, string precio, string stock)
        {
            this.idArticulo = idArticulo;
            this.producto = producto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
