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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string uConect;

        private void pBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.NombreUsuario = txtUsuario.Text.Trim();
            l.Contraseña = txtPass.Text.Trim();
            l.TipodeUsuario = cmbTipU.Text.Trim();

            //Comprobando las credenciales de inicio de sesion
            bool success = dal.LoginCheck(l);
            if (success == true)
            {
                //Login Successfull
                MessageBox.Show("Inicio de Sesión EXITOSO");
                //almacena el nombre del usuario
                uConect = l.NombreUsuario;

                //Abre el formulario respectivo segun el tipo de usuario
                switch (l.TipodeUsuario)
                {
                    case "Administrador":
                        {
                            //Display Admin Dashboard
                            frmPanelAdmin admin = new frmPanelAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "Usuario":
                        {
                            //Display User Dashboard
                            frmPanelUser user = new frmPanelUser();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //Display an error message
                            MessageBox.Show("El tipo de Usuario es INVALIDO.");
                        }
                        break;
                }
            }
            else
            {
                //Login Failed
                MessageBox.Show("Datos Incorrectos, Intente nuevamente");
            }



        }
    }
}
