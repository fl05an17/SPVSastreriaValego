using SPVSastreriaValego.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPVSastreriaValego.UI
{
    public partial class frmTransacciones : Form
    {
        public frmTransacciones()
        {
            InitializeComponent();
        }

        transaccioneDAL tDAL = new transaccioneDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmTransacciones_Load(object sender, EventArgs e)
        {
            DataTable dt = tDAL.MostrarTodasLasTransacciones();
            dgvTransacciones.DataSource = dt;
        }

        private void cmbTipoTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoTran.Text;

            DataTable dt = tDAL.MostrarTransaccionPorTipo(tipo);
            dgvTransacciones.DataSource = dt;
        }

        private void btnMostrarT_Click(object sender, EventArgs e)
        {
            DataTable dt = tDAL.MostrarTodasLasTransacciones();
            dgvTransacciones.DataSource = dt;
        }
    }
}
