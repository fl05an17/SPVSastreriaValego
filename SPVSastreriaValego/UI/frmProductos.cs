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

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //Creating DAtaTable to hold the categories from Database
            DataTable categoriasDT = cdal.Select();
            //Specify DataSource for category combobox
            cmbCategoria.DataSource = categoriasDT;
            //Specify Display Member and Value Member for Combobox
            cmbCategoria.DisplayMember = "Titulo";
            cmbCategoria.ValueMember = "Titulo";

        }
    }
}
