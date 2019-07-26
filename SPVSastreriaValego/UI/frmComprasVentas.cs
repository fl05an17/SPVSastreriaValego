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
using System.Transactions;
using System.Windows.Forms;

namespace SPVSastreriaValego.UI
{
    public partial class frmComprasVentas : Form
    {
        public frmComprasVentas()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        provclieDAL pcDAL = new provclieDAL();
        productosDAL pDAL = new productosDAL();
        usuariosDAL uDAL = new usuariosDAL();
        transaccioneDAL tDAL = new transaccioneDAL();
        transaccionesdetaDAL tdDAL = new transaccionesdetaDAL();

        DataTable transactionDT = new DataTable();

        private void frmComprasVentas_Load(object sender, EventArgs e)
        {
            //Get the transaccionesType value from frmUserDashboard
            string type = frmPanelUser.transaccionesType;
            //Set the value on lblTop
            lblTop.Text = type;

            //Specify Columns for our TransactionDataTable
            transactionDT.Columns.Add("Nombre");
            transactionDT.Columns.Add("Precio Unitario");
            transactionDT.Columns.Add("Cantidad");
            transactionDT.Columns.Add("Total");
        }

        private void txtBuscarPC_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from  the text box
            string keyword = txtBuscarPC.Text;

            if (keyword == "")
            {
                //Clear all the textboxes
                txtNombrePC.Text = "";
                txtCorreoPC.Text = "";
                txtTelefonoPC.Text = "";
                txtDireccionPC.Text = "";
                return;
            }

            //Write the code to get the details and set the value on text boxes
            provclieBLL pc = pcDAL.SearchProvClieForTransaction(keyword);

            //Now trasnfer or set the value from ProvCLieBLL to textbox
            txtNombrePC.Text = pc.Nombre;
            txtCorreoPC.Text = pc.Correo;
            txtTelefonoPC.Text = pc.Telefono;
            txtDireccionPC.Text = pc.Direccion;
        }

        private void btnNuevoProvClie_Click(object sender, EventArgs e)
        {
            frmProvClieU nprovclie = new frmProvClieU();
            nprovclie.Show();
        }

        private void txtBsucarProd_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBsucarProd.Text;

            if(keyword=="")
            {
                txtNombreProd.Text = "";
                txtInvenProd.Text = "";
                txtPrecioProd.Text = "";
                txtCantidadProd.Text = "";
                return;
            }
            productosBLL p = pDAL.GetProductsForTransaction(keyword);
            txtNombreProd.Text = p.Nombre;            
            txtPrecioProd.Text = p.Precio.ToString();
            txtInvenProd.Text = p.Cantidad.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //get product name, rate and qty customer wants to buy
            string nombreProd = txtNombreProd.Text;
            decimal Precio = decimal.Parse(txtPrecioProd.Text);
            decimal Cantidad = decimal.Parse(txtCantidadProd.Text);

            decimal Total = Precio * Cantidad;//Total PrecioCantidad

            //Display the subtotal in textbox
            //get the subtotal value from textbox
            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + Total;

            //Check wheter the product is selected or not
            if (nombreProd == "")
            {
                MessageBox.Show("Primero Seleccione un producto. Intente Nuevamente.");
            }
            else
            {
                //Add product data grid view 
                transactionDT.Rows.Add(nombreProd, Precio, Cantidad, Total);

                //Show in data grid view
                dgvProdAgre.DataSource = transactionDT;

                //Display the subtotal in textbox
                txtSubTotal.Text = subTotal.ToString();

                //Clear the textbox
                txtBsucarProd.Text = "";
                txtNombreProd.Text = "";
                txtInvenProd.Text = "0.00";
                txtPrecioProd.Text = "0.00";
                txtCantidadProd.Text = "0.00";
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            //Get the value form textbox descuento
            string value = txtDescuento.Text;

            if (value == "")
            {
                MessageBox.Show("Porfavor primero añada un descuento.");
            }
            else
            {
                //Get the discount in decimal value 
                decimal discount = decimal.Parse(txtDescuento.Text);
                decimal subTotal = decimal.Parse(txtSubTotal.Text);

                //Calculate the grandtotal based on discount 
                decimal granTotal = ((100 - discount) / 100) * subTotal;

                //Display the granTotal in textbox 
                txtGranTotal.Text = granTotal.ToString();
            }
        }

        private void txtMedioPago_TextChanged(object sender, EventArgs e)
        {
            
            //Get the paid amount and grand total 
            decimal granTotal = decimal.Parse(txtGranTotal.Text);
            decimal medioPago = decimal.Parse(txtMedioPago.Text);

            decimal returnAmount = medioPago - granTotal;

            txtDevolver.Text = returnAmount.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //get the values from purchaseSales form first 
            transaccionesBLL transaction = new transaccionesBLL();

            transaction.Tipo = lblTop.Text;

            //Get the ID Dealer or customer Here
            //Lets get name of the dealer or customer first
            string provClieNombre = txtNombrePC.Text;

            provclieBLL pc = pcDAL.GetProvclieIDFromName(provClieNombre);

            transaction.Prov_Clie_id = pc.id;
            transaction.GranTotal = Math.Round(decimal.Parse(txtGranTotal.Text),2);
            transaction.Fecha_Transaccion = DateTime.Now;
            transaction.Descuento = decimal.Parse(txtDescuento.Text);

            //get the username of logged in user
            string username = frmLogin.uConect;
            usuariosBLL u = uDAL.GetIDFromUsername(username);
            transaction.added_by = u.id;
            transaction.transactionDT = transactionDT;

            //Lets create a boolean variable and set its value to false
            bool success = false;
            
            //Actual code to insert transaction and transaction detail
            using(TransactionScope scope = new TransactionScope())
            {
                int transaccionID = -1;
                //Create a boolean value and insert transaction
                bool w = tDAL.Insert_Transacciones(transaction, out transaccionID);

                //use for loop to insert Transaction Details
                for(int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //get all the details of the product 
                    transaccionesdetaBLL transaccionesdeta = new transaccionesdetaBLL();
                    //Get the produt name and convert it to id 
                    string nomProduct = transactionDT.Rows[i][0].ToString();
                    productosBLL p = pDAL.GetProdcutIDFromName(nomProduct);

                    transaccionesdeta.Producto_id = p.id;
                    transaccionesdeta.Precio = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transaccionesdeta.Cantidad = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transaccionesdeta.Total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transaccionesdeta.Prov_Clie_id = pc.id;
                    transaccionesdeta.added_date = DateTime.Now;
                    transaccionesdeta.added_by = u.id;

                    //Here Increase or Decrease Product Quantity based on Purchase or sales
                    string transactionType = lblTop.Text;

                    bool x = false;
                    //lets check wheter we are on pruchase or sales 
                    if (transactionType == "COMPRAS")
                    {
                        //Increase the product
                        x = pDAL.IncreaseProduct(transaccionesdeta.Producto_id, transaccionesdeta.Cantidad);
                    }
                    else if (transactionType=="VENTAS")
                    {
                        //Decrease the product quantity
                        x = pDAL.DecreaseProduct(transaccionesdeta.Producto_id, transaccionesdeta.Cantidad);
                    }
                    //Insert Transaction Details inside the Database
                    bool y = tdDAL.InsertTransaccioneDetail(transaccionesdeta);
                    success = w && x && y;
                }

                if (success == true)
                    {
                        //transaction is complete 
                        scope.Complete();
                        MessageBox.Show("Transaccion Completada CORRECTAMENTE");
                        //clear the data grid view and clear all the textboxes
                        dgvProdAgre.DataSource = null;
                        dgvProdAgre.Rows.Clear();

                        txtBuscarPC.Text = "";
                        txtNombrePC.Text = "";
                        txtCorreoPC.Text = "";
                        txtTelefonoPC.Text = "";
                        txtDireccionPC.Text = "";
                        txtBsucarProd.Text = "";
                        txtNombreProd.Text = "";
                        txtInvenProd.Text = "0";
                        txtPrecioProd.Text = "0";
                        txtCantidadProd.Text = "0";
                        txtSubTotal.Text = "0";
                        txtDescuento.Text = "0";
                        txtGranTotal.Text = "0";
                        txtMedioPago.Text = "0";
                        txtDevolver.Text = "0";

                    }
                    else
                    {
                        MessageBox.Show("La Transaccion FALLO");
                    }

                
            }
            

        }
        
    }
}
