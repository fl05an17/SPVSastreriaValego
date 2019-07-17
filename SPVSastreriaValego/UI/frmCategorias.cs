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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriasBLL c = new categoriasBLL();
        categoriasDAL dal = new categoriasDAL();
        usuariosDAL udal = new usuariosDAL();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Get the values from category Form
            c.Titulo = txtNomCate.Text;
            c.Descripcion = txtDescr.Text;
            c.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggedUser = frmLogin.uConect;
            usuariosBLL usr = udal.GetIDFromUsername(loggedUser);

            //Passign the id of Logged in user in added by field 
            c.added_by = usr.id;

            //Creating Boolean Method to insert data into database 
            bool success = dal.Insert(c);

            //If the category is insert successfully then the value of the success will be true else it will be false 
            if (success == true)
            {
                //NewCategory Inserted successfully
                MessageBox.Show("Nueva Categoria insertada CORRECTAMENTE");
                Clear();
                //Refresh Daa Grid View
                DataTable dt = dal.Select();
                dgvCategorias.DataSource = dt;
            }
            else
            {
                //Failed to insert new category 
                MessageBox.Show("FALLO al insertar Nueva Categoria");
            }
        }
        public void Clear()
        {
            txtIdCate.Text = "";
            txtNomCate.Text = "";
            txtDescr.Text = "";
            txtBuscar.Text = "";
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            //Here write the code to display all the categries in Data Grid View 
            DataTable dt = dal.Select();
            dgvCategorias.DataSource = dt;
        }

        private void dgvCategorias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Finding the row Index of the row clicked on data grid view 
            int RowIndex = e.RowIndex;
            txtIdCate.Text = dgvCategorias.Rows[RowIndex].Cells[0].Value.ToString();
            txtNomCate.Text = dgvCategorias.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescr.Text = dgvCategorias.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Get the values from the category form
            c.id = int.Parse(txtIdCate.Text);
            c.Titulo = txtNomCate.Text;
            c.Descripcion = txtDescr.Text;
            c.added_date = DateTime.Now;
            //Getting ID in added by field
            string loggedUser = frmLogin.uConect;
            usuariosBLL usr = udal.GetIDFromUsername(loggedUser);
            //Passign the id of Logged in user in added by field 
            c.added_by = usr.id;

            //Creating boolena variable to update categories and check
            bool success = dal.Update(c);
            //if the category is update successfully the the value of success will be true else it will be false
            if (success == true)
            {
                //Category Updated Successfully
                MessageBox.Show("La Categoria fue Actualizada CORRECTAMENTE");
                Clear();
                //Refresh Data Grid View
                DataTable dt = dal.Select();
                dgvCategorias.DataSource = dt;

            }
            else
            {
                //failed to update category
                MessageBox.Show("FALLO al Actualizar la Categoria");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Get the ID of the Category Which we want to Delete 
            c.id = int.Parse(txtIdCate.Text);
            //Creating boolean variable to delete the category 
            bool success = dal.Delete(c);
            //If category id deleted successfully the the value of success will be true else it will be false 
            if (success == true)
            {
                //Category Deleted Successfully
                MessageBox.Show("Categoria Eliminada CORRECTAMENTE");
                Clear();
                //Refresh data grid view
                DataTable dt = dal.Select();
                dgvCategorias.DataSource = dt;
            }
            else
            {
                //Failed to delete category
                MessageBox.Show("FALLO al Eliminar la Categoria");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Get the keywords 
            string keywords = txtBuscar.Text;

            //Filter the categories based on keywords
            if (keywords != null)
            {
                //Use search method to display categories
                DataTable dt = dal.Search(keywords);
                dgvCategorias.DataSource = dt;
            }
            else
            {
                //use select method to display all categories
                DataTable dt = dal.Select();
                dgvCategorias.DataSource = dt;
            }
        }
    }
}
