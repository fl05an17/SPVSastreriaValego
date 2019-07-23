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
    public partial class frmPanelUser : Form
    {
        public frmPanelUser()
        {
            InitializeComponent();
        }

        private void frmPanelUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmPanelUser_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.uConect;
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComprasVentas comVen = new frmComprasVentas();
            comVen.Show();
        }

        private void formulariosDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComprasVentas comVen = new frmComprasVentas();
            comVen.Show();
        }
    }
}
