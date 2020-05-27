using SourceCode.Controlador;
using SourceCode.Modelo;
using SourceCode.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            picLogo.BackgroundImage = Image.FromFile("../../Recursos/hugo_icon.png");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PoblarControlers();
        }

        private void PoblarControlers()
        {
            cmbLogUser.DataSource = null;
            cmbLogUser.ValueMember = "Contrasena";
            cmbLogUser.DisplayMember = "NombreUsuario";
            cmbLogUser.DataSource = ControladorUsuario.GetUsuarios();


        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("No deje camposa vacios", "", MessageBoxButtons.OK);
            }
            else
            {
                if (txtPassword.Text.Equals(cmbLogUser.SelectedValue.ToString()))
                {
                    frmMain frmMain = new frmMain((Usuario) cmbLogUser.SelectedItem);
                    Hide();
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.\nIntente denuevo mas tarde", "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePass frmChangePass = new FrmChangePass();
            frmChangePass.Show();
            
        }
    }
}
