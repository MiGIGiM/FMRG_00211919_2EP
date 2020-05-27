using SourceCode.Modelo;
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
                tableUsuarios = ConnectionDB.EjecutarConsulta("SELECT * FROM APPUSER");
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
                        dr[3].ToString(),
                        Convert.ToBoolean(dr[4].ToString())
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
                tableUsuarios = ConnectionDB.EjecutarConsulta("SELECT * FROM APPUSER");
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
                ConnectionDB.EjecutarComando($"UPDATE APPUSER SET password = '{nueva}' " +
                    $"WHERE idUser = {idUsuario}");

                MessageBox.Show("Se ha actualizado la contraseña exitosamente", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        

        public static void CrearUsuario(string usuario, string fullname)
        {
            try
            {
                ConnectionDB.EjecutarComando("INSERT INTO APPUSER(fullname, username, password, usertype)" +
                    $" VALUES('{fullname}', '{usuario}', '{usuario}', false)");

                MessageBox.Show("Se ha agregado el nuevo usuario.\n" +
                    "Valores por defecto: contraseña igual a nombre de usuario", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
