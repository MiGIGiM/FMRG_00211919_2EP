using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Modelo
{
    public class Usuario
    {
        public string IdUsuario { get; set; }

        public string NombreCompleto { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public bool Admin { get; set; }

        public Usuario(string idUsuario, string nombreCompleto, string nombreUsuario, string contrasena, bool admin)
        {
            IdUsuario = idUsuario;
            NombreCompleto = nombreCompleto;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Admin = admin;
        }
    }
}
