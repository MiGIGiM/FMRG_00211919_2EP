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

            cmbNombreNeg.DataSource = cmbNegocios.DataSource = null;
            cmbNombreNeg.ValueMember = cmbNegocios.ValueMember = "Nombre";
            cmbNegocios.DisplayMember = "Nombre";
            cmbNombreNeg.DataSource = cmbNegocios.DataSource = ControladorNegocios.GetNegocios();


            cmbNombreProd.DataSource = null;
            cmbNombreProd.ValueMember = "NombreProd";
            cmbNombreProd.DisplayMember = "NombreProd";
            cmbNombreProd.DataSource = ControladorProducto.GetProductos();


            dgvUsers.DataSource = ControladorUsuario.GetUsuariosTable();

            dgvNegocios.DataSource = ControladorNegocios.GetNegociosTable();

            dgvProd.DataSource = ControladorProducto.GetProductosTable();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {     
            if (u.Admin)
            {
                CargarListas();
                GetUsernames();
                dgvPedidos.DataSource = ControladorPedido.GetPedidosTable();
            }
            else
            {

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
            if (MessageBox.Show("¿Seguro que desea eliminar el negocio?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var obtenerId = (Producto)cmbNombreProd.SelectedItem;
                ControladorProducto.EliminarProducto(obtenerId.IdProduct.ToString());
                CargarListas();
            }
        }
    }
}
