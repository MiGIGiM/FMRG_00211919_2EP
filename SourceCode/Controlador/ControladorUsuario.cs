using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.Controlador
{
    public static class ControladorUsuario
    {
        // Metodo que devuelve todos los usuarios en formato de lista
        public static List<Usuario> GetUsuarios()
        {
            var usuarios = new List<Usuario>();
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConnectionDB.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            foreach (DataRow dr in tableUsuarios.Rows)
            {
                usuarios.Add(new Usuario
                    (
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        Convert.ToBoolean(dr[3].ToString())
                    )
                );
            }

            return usuarios;
        }

        public static DataTable GetUsuariosTable()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConnectionDB.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }


        public static void ActualizarContrasena(string idUsuario, string nueva)
        {
            try
            {
                ConnectionDB.EjecutarComando($"UPDATE USUARIO SET contrasenia = '{nueva}' " +
                    $"WHERE idUsuario = {idUsuario}");

                MessageBox.Show("Se ha actualizado la contrasena");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        

        public static void CrearUsuario(string usuario)
        {
            try
            {
                ConnectionDB.EjecutarComando("INSERT INTO USUARIO(nombreUsuario, contrasenia, tipo)" +
                    $" VALUES('{usuario}', '{usuario}', false)");

                MessageBox.Show("Se ha agregado el nuevo usuario, contrasenia igual al nombre");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
