using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Modelo
{
    public class Direcciones
    {
        public int IdAddress { get; set; }
        public int IdUser { get; set; }
        public string Address { get; set; }

        public Direcciones(int idAddress, int idUser, string address)
        {
            IdAddress = idAddress;
            IdUser = idUser;
            Address = address;
        }
    }
}
