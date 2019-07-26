using SPVSastreriaValego.BLL;
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
    public partial class frmProvClieU : Form
    {
        public frmProvClieU()
        {
            InitializeComponent();
        }

        provclieBLL pc = new provclieBLL();
        provclieDAL pcdal = new provclieDAL();
        usuariosDAL udal = new usuariosDAL();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pc.Tipo = cmbTipo.Text;
            pc.Nombre = txtNombre.Text;
            pc.Correo = txtCorreo.Text;
            pc.Telefono = txtTelefono.Text;
            pc.Direccion = txtDireccion.Text;
            pc.added_date = DateTime.Now;
            String loggedUsr = frmLogin.uConect;
            usuariosBLL usr = udal.GetIDFromUsername(loggedUsr);
            pc.added_by = usr.id;

            bool success = pcdal.Insert(pc);

            if (success == true)
            {
                MessageBox.Show("Cliente o Proveedor Agregado CORRECTAMENTE");
                Clear();
                DataTable dt = pcdal.Select();
                dgvProveClien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("FALLO al Agregar Cliente o Proveedor");
            }
        }

        public void Clear()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmProvClieU_Load(object sender, EventArgs e)
        {
            DataTable dt = pcdal.Select();
            dgvProveClien.DataSource = dt;
        }

        private void dgvProveClien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvProveClien.Rows[rowIndex].Cells[0].Value.ToString();
            cmbTipo.Text = dgvProveClien.Rows[rowIndex].Cells[1].Value.ToString();
            txtNombre.Text = dgvProveClien.Rows[rowIndex].Cells[2].Value.ToString();
            txtCorreo.Text = dgvProveClien.Rows[rowIndex].Cells[3].Value.ToString();
            txtTelefono.Text = dgvProveClien.Rows[rowIndex].Cells[4].Value.ToString();
            txtDireccion.Text = dgvProveClien.Rows[rowIndex].Cells[5].Value.ToString();
        }
    }
}
