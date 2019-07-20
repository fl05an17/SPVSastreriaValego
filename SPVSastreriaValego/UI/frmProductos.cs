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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriasDAL cdal = new categoriasDAL();
        productosBLL p = new productosBLL();
        productosDAL pdal = new productosDAL();
        usuariosDAL udal = new usuariosDAL();

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //Creating DAtaTable to hold the categories from Database
            DataTable categoriasDT = cdal.Select();
            //Specify DataSource for category combobox
            cmbCategoria.DataSource = categoriasDT;
            //Specify Display Member and Value Member for Combobox
            cmbCategoria.DisplayMember = "Titulo";
            cmbCategoria.ValueMember = "Titulo";
            DataTable dt = pdal.Select();
            dgvProductos.DataSource = dt;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p.Nombre = txtNombre.Text;
            p.Categoria = cmbCategoria.Text;
            p.Descripcion = txtDescr.Text;
            p.Precio = decimal.Parse(txtPrecio.Text);
            p.Cantidad = 0;
            p.added_date = DateTime.Now;
            String loggedUsr = frmLogin.uConect;
            usuariosBLL usr = udal.GetIDFromUsername(loggedUsr);
            p.added_by = usr.id;

            bool success = pdal.Insert(p);

            if (success == true)
            {
                MessageBox.Show("Producto Agregado CORRETAMENTE");
                Clear();
                DataTable dt = pdal.Select();
                dgvProductos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("FALLO al Aagregar Producto");  
            }
        }

        public void Clear()
        {
            txtPid.Text = "";
            txtNombre.Text = "";
            txtDescr.Text = "";
            txtPrecio.Text = "";
            txtBuscar.Text = "";
        }

        private void dgvProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtPid.Text = dgvProductos.Rows[rowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategoria.Text = dgvProductos.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescr.Text = dgvProductos.Rows[rowIndex].Cells[3].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtPid.Text);
            p.Nombre = txtNombre.Text;
            p.Categoria = cmbCategoria.Text;
            p.Descripcion = txtDescr.Text;
            p.Precio = decimal.Parse(txtPrecio.Text);
            p.added_date = DateTime.Now;
            String loggedUsr = frmLogin.uConect;
            usuariosBLL usr = udal.GetIDFromUsername(loggedUsr);
            p.added_by = usr.id;

            bool success = pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show("El Producto fue Actualizado CORRECTAMENTE");
                Clear();
                DataTable dt = pdal.Select();
                dgvProductos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("FALLO al Actualizar el Producto");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtPid.Text);
            bool success = pdal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("El Producto fue Eliminado CORRECTAMENTE");
                Clear();
                DataTable dt = pdal.Select();
                dgvProductos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fallo al Eliminar Producto");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtBuscar.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgvProductos.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProductos.DataSource = dt;
            }
        }
    }
}
