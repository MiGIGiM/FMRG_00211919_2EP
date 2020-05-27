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

            dgvUsers.DataSource = ControladorUsuario.GetUsuariosTable();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CargarListas();
            GetUsernames();
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
    }
}
