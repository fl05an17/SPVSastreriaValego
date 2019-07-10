using SPVSastreriaValego.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPVSastreriaValego
{
    public partial class frmPanelAdmin : Form
    {
        public frmPanelAdmin()
        {
            InitializeComponent();
        }

        /*Creacion de objeto 'usuario' para mostrar el formulario de usuario cuando se haga click
          en el boton usuarios del panel administrador*/
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();//Nuevo objeto usuario
            usuario.Show();//Mostrar el formulario de usuario
        }

        private void frmPanelAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmPanelAdmin_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.uConect;
        }
    }
}
