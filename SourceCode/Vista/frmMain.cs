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
    public partial class frmMain : Form
    {
        private Usuario u;

        public frmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }

    }
}
