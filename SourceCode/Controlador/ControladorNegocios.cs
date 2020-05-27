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
    public static class  ControladorNegocios
    {
         public static List<Negocios> GetNegocios()
        {
        var negocios = new List<Negocios>();
        DataTable tableNegocios = null;

        try
        {
                tableNegocios = ConnectionDB.EjecutarConsulta("SELECT * FROM BUSINESS");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        foreach (DataRow dr in tableNegocios.Rows)
        {
                negocios.Add(new Negocios
                (
                    Convert.ToInt32(dr[0].ToString()),
                    dr[1].ToString(),
                    dr[2].ToString()
                )
            ); ;
        }

        return negocios;
        }

        public static DataTable GetNegociosTable()
        {
            DataTable tableNegocios = null;

            try
            {
                tableNegocios = ConnectionDB.EjecutarConsulta("SELECT * FROM BUSINESS");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tableNegocios;
        }

        public static void CrearNegocio(string name, string desc)
        {
            try
            {
                ConnectionDB.EjecutarComando("INSERT INTO BUSINESS(name, description) " +
                    $"VALUES('{name}', '{desc}')");

                MessageBox.Show("Se ha agregado el nuevo negocio.\n",
                    " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        public static void EliminarNegocio(string id)
        {
            try
            {
                ConnectionDB.EjecutarComando($"DELETE FROM BUSINESS WHERE idbusiness = {id}");

                MessageBox.Show("Se ha eliminado el negocio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
