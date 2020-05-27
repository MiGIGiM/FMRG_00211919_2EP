using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Modelo
{
    public class Producto
    {
        public int IdProduct { get; set; }
        public int IdBusiness { get; set; }
        public string NombreProd { get; set; }

        public Producto(int idProduct, int idBusiness, string nombreProd)
        {
            IdProduct = idProduct;
            IdBusiness = idBusiness;
            NombreProd = nombreProd;
        }
    }
}
