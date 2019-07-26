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
    class transaccioneDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Transaction Method
        public bool Insert_Transacciones(transaccionesBLL t, out int transaccionID)
        {
            bool isSuccess = false;
            //set the out transaccionID value to negative 1 i.e. -1
            transaccionID = -1;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Transacciones (Tipo, Prov_Clie_id, GranTotal, Fecha_Transaccion, Descuento, added_by) VALUES (@Tipo, @Prov_Clie_id, @GranTotal, @Fecha_Transaccion, @Descuento, @added_by); SELECT @@IDENTITY;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Tipo", t.Tipo);
                cmd.Parameters.AddWithValue("@Prov_Clie_id", t.Prov_Clie_id);
                cmd.Parameters.AddWithValue("@GranTotal", t.GranTotal);
                cmd.Parameters.AddWithValue("@Fecha_Transaccion", t.Fecha_Transaccion);                
                cmd.Parameters.AddWithValue("@Descuento", t.Descuento);
                cmd.Parameters.AddWithValue("added_by", t.added_by);

                conn.Open();

                //Execute the query 
                object o = cmd.ExecuteScalar();

                //If the query is executed succesfully then value will not be null else it will be null
                if (o != null)
                {
                    transaccionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
                else
                {
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
        #endregion
        #region Method to display all the transaction
        public DataTable MostrarTodasLasTransacciones()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_Transacciones";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region Method To Display Transaction Based On Transaction Type
        public DataTable MostrarTransaccionPorTipo(string tipo)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_Transacciones WHERE Tipo='" + tipo + "'";                

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #endregion
    }
}
