using SourceCode.Controlador;
using SourceCode.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.Vista
{
    public partial class frmMain : Form
    {
        private Usuario u;
        
        public frmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void CargarListas()
        {
            cmbDeleteUser.DataSource = null;
            cmbDeleteUser.ValueMember = "NombreUsuario";
            cmbDeleteUser.DisplayMember = "NombreUsuario";
            cmbDeleteUser.DataSource = ControladorUsuario.GetUsuarios();

            cmbDireccion.DataSource = null;
            cmbDireccion.ValueMember = "Address";
            cmbDireccion.DisplayMember = "Address";
           cmbDireccion.DataSource = ControladorDireccion.GetDireccion();


            cmbNegocios.DataSource = null;
            cmbNegocios.ValueMember = "Nombre";
            cmbNegocios.DisplayMember = "Nombre";
            cmbNegocios.DataSource = ControladorNegocios.GetNegocios();

            cmbNombreNeg.DataSource = null;
            cmbNombreNeg.ValueMember = "Nombre";
            cmbNombreNeg.DisplayMember = "Nombre";
            cmbNombreNeg.DataSource = ControladorNegocios.GetNegocios();


            cmbNombreProd.DataSource = null;
            cmbNombreProd.ValueMember = "NombreProd";
            cmbNombreProd.DisplayMember = "NombreProd";
            cmbNombreProd.DataSource = ControladorProducto.GetProductos();

            cmbProductos.DataSource = null;
            cmbProductos.ValueMember = "IdPedido";
            cmbProductos.DisplayMember = "NombreProd";
            cmbProductos.DataSource = ControladorProducto.GetProductos();


            dgvUsers.DataSource = ControladorUsuario.GetUsuariosTable();

            dgvNegocios.DataSource = ControladorNegocios.GetNegociosTable();

            dgvProd.DataSource = ControladorProducto.GetProductosTable();

            dgvDeletePedido.DataSource = dgvPedidos.DataSource = ControladorPedido.GetPedidosTable(u.IdUsuario.ToString());

        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            CargarListas();
            if (u.Admin)
            {
                GetUsernames();
                dgvPedidos.DataSource = ControladorPedido.GetPedidosTable();
                tabOpciones.TabPages[4].Parent = null;
                tabOpciones.TabPages[4].Parent = null;
            }
            else
            {
                tabOpciones.TabPages[0].Parent = null;
                tabOpciones.TabPages[0].Parent = null;
                tabOpciones.TabPages[0].Parent = null;

            }

        }

        private List<string> GetUsernames()
        {
            var usernames = new List<string>();
            var users = ConnectionDB.EjecutarConsulta("SELECT username FROM APPUSER");

            foreach (DataRow dr in users.Rows)
            {
                usernames.Add(dr[0].ToString());
            }

            return usernames;
        }

        private bool Available(List<string> list, string cadena)
        {
            foreach (string st in list)
            {
                if (st.Equals(cadena, StringComparison.InvariantCultureIgnoreCase))
                    return true;

            }
            return false;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text.Equals("") || txtFullname.Text.Equals(""))
                {
                    MessageBox.Show("No deje campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Available(GetUsernames(), txtUsername.Text))
                        {
                            MessageBox.Show("Nombre de usuario no disponible"
                                , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Text = "";
                        }
                    else
                    {
                        ControladorUsuario.CrearUsuario(txtUsername.Text, txtFullname.Text);
                        txtUsername.Text = "";
                        txtFullname.Text = "";
                        CargarListas();
                    }
 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Seguro que desea eliminar a " + cmbDeleteUser.SelectedValue.ToString() + "?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConnectionDB.EjecutarComando($"DELETE FROM APPUSER " +
                        $"WHERE username = '{cmbDeleteUser.SelectedValue.ToString()}'");
                    MessageBox.Show("Se ha eliminado al usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CargarListas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNeg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescNeg.Text.Equals("") || txtNombreNeg.Text.Equals(""))
                {
                    MessageBox.Show("No deje campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string auxname = txtNombreNeg.Text, auxdesc = txtDescNeg.Text;
                    ControladorNegocios.CrearNegocio(auxname,auxdesc);
                    txtNombreNeg.Text = "";
                    txtDescNeg.Text = "";
                    CargarListas();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salió mal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteNeg_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea eliminar el negocio?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var obteneriD = (Negocios)cmbNombreNeg.SelectedItem;
                    ControladorNegocios.EliminarNegocio(obteneriD.IdNegocio.ToString());
                    CargarListas();
                }

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if (txtNameProd.Text.Equals(""))
            {
                MessageBox.Show("No deje campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var obtenerId = (Negocios)cmbNegocios.SelectedItem;
                ControladorProducto.CrearProducto(obtenerId.IdNegocio.ToString(),txtNameProd.Text);
                txtNameProd.Text = "";
                CargarListas();
            }
        }

        private void btnDeleteProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el Producto?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var obtenerId = (Producto)cmbNombreProd.SelectedItem;
                ControladorProducto.EliminarProducto(obtenerId.IdProduct.ToString());
                CargarListas();
            }
        }

        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            var obtenerId = (Direcciones)cmbDireccion.SelectedItem;
            var prodId = (Producto)cmbProductos.SelectedItem;
            var fecha = DateTime.Now.ToString("dd-MM-yyyy");
            ControladorPedido.CrearPedido(DateTime.Now, prodId.IdProduct.ToString(), obtenerId.IdAddress.ToString());

            CargarListas();
        }

        private void btnDeleteDir_Click(object sender, EventArgs e)
        {
            if (txtIdPedido.Text.Equals(""))
            {
                MessageBox.Show("No deje campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el Pedido?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ControladorPedido.EliminarPedido(txtIdPedido.Text);
                    CargarListas();
                }
            }
        }

        private void btnAddDir_Click(object sender, EventArgs e)
        {
            if (txtDir.Equals(""))
            {
                MessageBox.Show("No deje campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ControladorDireccion.CrearDireccion(u.IdUsuario.ToString(), txtDir.Text);
                CargarListas();

            }
        }

        private void btnBorrarDireccion_Click(object sender, EventArgs e)
        {
            if (txtEliminarDir.Text.Equals(""))
            {
                MessageBox.Show("No deje campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el Pedido?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ControladorDireccion.EliminarDireccion(txtEliminarDir.Text);
                    CargarListas();
                }
            }
        }
    }
}
