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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        usuariosBLL u = new usuariosBLL();
        usuariosDAL dal = new usuariosDAL();


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //Getting Data From UI
            u.Nombre = txtNombre.Text;
            u.Apellido = txtApellido.Text;
            u.Correo = txtCorreo.Text;
            u.NombreUsuario = txtUsuario.Text;
            u.Contraseña = txtPass.Text;
            u.Telefono = txtTelefono.Text;
            u.Direccion = txtDireccion.Text;
            u.Genero = cmbGenero.Text;
            u.TipodeUsuario = cmbTusuario.Text;
            u.added_date = DateTime.Now;
            //Getting Username of the logged in user
            string loggedUser = frmLogin.uConect;
            usuariosBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;

            //Iserting Data into DataBase
            bool success = dal.Insert(u);
            //Si los datos son INSERTADOS correctamente el valor del success sera verdadero, de lo contrario sera falso
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("El Usuario fue AGREGADO con ÉXITO");
                LimpiarCampos();
            }
            else
            {
                //Failed to insert Data
                MessageBox.Show("FALLO al AGREGAR Nuevo Usuario");

            }
            //Refreshing data grid view
            DataTable dt = dal.Select();
            dgvUsuarios.DataSource = dt;

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsuarios.DataSource = dt;
        }

        private void LimpiarCampos()
        {
            txtIduser.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbGenero.Text = "";
            cmbTusuario.Text = "";
        }

        private void dgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtener el indice de una fila particular
            int rowIndex = e.RowIndex;//nod dara el valor de la fila seleccionada
            txtIduser.Text = dgvUsuarios.Rows[rowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.Rows[rowIndex].Cells[1].Value.ToString();
            txtApellido.Text = dgvUsuarios.Rows[rowIndex].Cells[2].Value.ToString();
            txtCorreo.Text = dgvUsuarios.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsuario.Text = dgvUsuarios.Rows[rowIndex].Cells[4].Value.ToString();
            txtPass.Text = dgvUsuarios.Rows[rowIndex].Cells[5].Value.ToString();
            txtTelefono.Text = dgvUsuarios.Rows[rowIndex].Cells[6].Value.ToString();
            txtDireccion.Text = dgvUsuarios.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGenero.Text = dgvUsuarios.Rows[rowIndex].Cells[8].Value.ToString();
            cmbTusuario.Text = dgvUsuarios.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Get the values from User UI
            u.id = Convert.ToInt32(txtIduser.Text);
            u.Nombre = txtNombre.Text;
            u.Apellido = txtApellido.Text;
            u.Correo = txtCorreo.Text;
            u.NombreUsuario = txtUsuario.Text;
            u.Contraseña = txtPass.Text;
            u.Telefono = txtTelefono.Text;
            u.Direccion = txtDireccion.Text;
            u.Genero = cmbGenero.Text;
            u.TipodeUsuario = cmbTusuario.Text;
            u.added_date = DateTime.Now;
            //Getting Username of the logged in user
            string loggedUser = frmLogin.uConect;
            usuariosBLL usr = dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;

            //Updating into DataBase
            bool success = dal.Update(u);
            //Si los datos son ACTUALIZADOS correctamente el valor del success sera verdadero, de lo contrario sera falso
            if(success == true)
            {
                //Data Update SuccessFully
                MessageBox.Show("El Usuario fue ACTUALIZADO con ÉXITO");
                LimpiarCampos();
            }
            else
            {
                //Failed to Update User
                MessageBox.Show("FALLO al ACTUALIZAR el Usuario");

            }
            //Refreshing data grid view
            DataTable dt = dal.Select();
            dgvUsuarios.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Get user ID from FOrm
            u.id = Convert.ToInt32(txtIduser.Text);
            bool success = dal.Delete(u);
            //Si los datos son ELIMINADOS correctamente el valor del success sera verdadero, de lo contrario sera falso
            if(success == true)
            {
                //Data Delete Succesfully
                MessageBox.Show("El Usuario fue ELIMINADO con ÉXITO");
                LimpiarCampos();
            }
            else
            {
                //Failed to Delete User
                MessageBox.Show("FALLO al ELIMINAR el Usuario");
            }
            //Refreshing data grid view
            DataTable dt = dal.Select();
            dgvUsuarios.DataSource = dt;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Get Keybord from textbox
            string keywords = txtBuscar.Text;

            //chec if the keywords has value or not
            if (keywords != null)
            {
                //Show user based on keywords
                DataTable dt = dal.Search(keywords);
                dgvUsuarios.DataSource = dt;
            }
            else
            {
                //show all users from the database 
                DataTable dt = dal.Select();
                dgvUsuarios.DataSource = dt;
            }


             
        }
        
    }
}
