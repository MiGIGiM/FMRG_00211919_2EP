using SourceCode.Controlador;
using SourceCode.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.Vista
{
    public partial class FrmChangePass : Form
    {
        public FrmChangePass()
        {
            InitializeComponent();
        }

        private void FrmChangePass_Load(object sender, EventArgs e)
        {

            ActualizarControles();
        }

        private void ActualizarControles()
        {
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "Contrasena";
            cmbUser.DisplayMember = "NombreUsuario";
            cmbUser.DataSource = ControladorUsuario.GetUsuarios();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtPassActual.Text.Equals(cmbUser.SelectedValue.ToString()))
            {
                // Se obtiene el objeto del SelectedItem y con polimorfismo se convierte a Usuario
                var obtenerUsuario = (Usuario)cmbUser.SelectedItem;

                // Se actualiza la contrasena enviando el id del usuario obtenido
                ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
                    txtNewPass.Text);

                ActualizarControles();
            }
            else
                MessageBox.Show("Contraseña actual incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
