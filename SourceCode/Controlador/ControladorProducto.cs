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
    public static class ControladorProducto
    {
        public static List<Producto> GetProductos()
        {
            var productos = new List<Producto>();
            DataTable tableProductos = null;
            try
            {
                tableProductos = ConnectionDB.EjecutarConsulta("SELECT * FROM PRODUCT");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow dr in tableProductos.Rows)
            {
                productos.Add(new Producto
                (
                    Convert.ToInt32(dr[0].ToString()),
                    Convert.ToInt32(dr[1].ToString()),
                    dr[2].ToString()
                )); ;
            }
            return productos;
        }

        public static DataTable GetProductosTable()
        {
            DataTable tableproductos = null;

            try
            {
                tableproductos = ConnectionDB.EjecutarConsulta("SELECT * FROM PRODUCT");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tableproductos;
        }

        public static void CrearProducto(string id, string name)
        {
            try
            {
                ConnectionDB.EjecutarComando($"INSERT INTO PRODUCT(idBusiness, name) " +
                    $"VALUES('{id}', '{name}')");

                MessageBox.Show("Se ha agregado el nuevo producto.\n",
                    " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        public static void EliminarProducto(string id)
        {
            try
            {
                ConnectionDB.EjecutarComando($"DELETE FROM PRODUCT WHERE idproduct = {id}");

                MessageBox.Show("Se ha eliminado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
