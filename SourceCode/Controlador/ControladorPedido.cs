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
    public static class ControladorPedido
    {
        public static List<Pedido> GetPedidos()
        {
            var pedidos = new List<Pedido>();
            DataTable tablepedidos = null;

            try
            {
                tablepedidos = ConnectionDB.EjecutarConsulta("SELECT * FROM APPORDER");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow dr in tablepedidos.Rows)
            {
                pedidos.Add(new Pedido
                    (
                        Convert.ToInt32(dr[0].ToString()),
                        Convert.ToDateTime(dr[1].ToString()),
                        Convert.ToInt32(dr[2].ToString()),
                        Convert.ToInt32(dr[3].ToString())
                    )
                );
            }

            return pedidos;
        }


        public static DataTable GetPedidosTable()
        {
            DataTable tablepedidos = null;

            try
            {
                tablepedidos = ConnectionDB.EjecutarConsulta($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " + 
                                                             "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+ 
                                                             "WHERE ao.idProduct = pr.idProduct " + 
                                                             "AND ao.idAddress = ad.idAddress " + 
                                                             "AND ad.idUser = au.idUser");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tablepedidos;
        }
        public static DataTable GetPedidosTable(string idUser)
        {
            DataTable tablepedidos = null;

            try
            {
                tablepedidos = ConnectionDB.EjecutarConsulta($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                                             "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                             "WHERE ao.idProduct = pr.idProduct " +
                                                             "AND ao.idAddress = ad.idAddress " +
                                                             $"AND ad.idUser = au.idUser " +
                                                             $"AND au.idUser ={idUser} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tablepedidos;
        }


        public static void CrearPedido(DateTime date ,string idP, string idA)
        {

                ConnectionDB.EjecutarComando($"INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                                             $"VALUES('{date}', '{idP}', '{idA}')");

                MessageBox.Show("Se ha agregado el pedido.\n",
                    " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           /* }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }*/
        }

        public static void EliminarPedido(string id)
        {

                ConnectionDB.EjecutarComando($"DELETE FROM APPORDER WHERE idorder = '{id}'");

                MessageBox.Show("Se ha eliminado el producto");

            /*catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }*/
        }

    }
}
