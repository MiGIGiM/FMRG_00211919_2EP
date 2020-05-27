using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Modelo
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime Createdate { get; set; }
        public int IdProducto { get; set; }
        public int IdAdress { get; set; }

        public Pedido(int idPedido, DateTime createdate, int idProducto, int idadress)
        {
            IdPedido = idPedido;
            Createdate = createdate;
            IdProducto = idProducto;
            IdAdress = idadress;
        }
    }
}
