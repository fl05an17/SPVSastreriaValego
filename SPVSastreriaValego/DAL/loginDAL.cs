using SPVSastreriaValego.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPVSastreriaValego.DAL
{
    class loginDAL
    {
        //Cadena static para conectar la base de datos
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool LoginCheck(loginBLL l)
        {
            //Crea variable booleana y establece el valor en falso y luego lo retorna
            bool isSuccess = false;

            //Conectando a la base de datos
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Consulta (Query) para comprobar el login
                string sql = "SELECT * FROM tbl_Usuarios WHERE NombreUsuario=@NombreUsuario AND Contraseña=@Contraseña AND TipodeUsuario=@TipodeUsuario";

                //Creando Comando SQL para pasar los valores
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", l.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", l.Contraseña);
                cmd.Parameters.AddWithValue("@TipodeUsuario", l.TipodeUsuario);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Revisando las filas en las tabla de datos
                if (dt.Rows.Count > 0)
                {
                    //Login Successful
                    isSuccess = true;
                }
                else
                {
                    //Login Failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
