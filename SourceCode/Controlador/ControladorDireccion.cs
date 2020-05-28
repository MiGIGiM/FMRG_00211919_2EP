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
    public static class ControladorDireccion
    {
        public static List<Direcciones> GetDireccion()
        {
            var direcciones = new List<Direcciones>();
            DataTable tableDirecciones = null;
            try
            {
                tableDirecciones = ConnectionDB.EjecutarConsulta("SELECT * FROM ADDRESS");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow dr in tableDirecciones.Rows)
            {
                direcciones.Add(new Direcciones
                (
                    Convert.ToInt32(dr[0].ToString()),
                    Convert.ToInt32(dr[1].ToString()),
                    dr[2].ToString()
                )); ;
            }
            return direcciones;
        }

        public static DataTable GetDireccionesTable(string id)
        {
            DataTable tableNegocios = null;

            try
            {
                tableNegocios = ConnectionDB.EjecutarConsulta($"SELECT address FROM ADDRESS WHERE iduser = '{id}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tableNegocios;
        }

        public static void CrearDireccion(string name, string id)
        {
            try
             {
                     ConnectionDB.EjecutarComando($"INSERT INTO ADDRESS(iduser, address) " +
                     $"VALUES({id}, '{name}')");
                 MessageBox.Show("Se ha agregado dirección.\n",
                     " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             catch(Exception ex)
             {
                 MessageBox.Show("Ha ocurrido un error");
             }
        }

        public static void EliminarDireccion(string id)
        {
            try
            {
                ConnectionDB.EjecutarComando($"DELETE FROM ADDRESS WHERE idUser = {id}");

                MessageBox.Show("Se ha eliminado la dirección");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
