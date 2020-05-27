using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Modelo
{
    public class Negocios
    { 
        public int IdNegocio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Negocios(int idNegocio, string nombre, string descripcion)
        {
            IdNegocio = idNegocio;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
