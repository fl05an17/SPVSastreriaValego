using SPVSastreriaValego.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPVSastreriaValego.DAL
{
    class transaccionesdetaDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Method for Transacciones Detail
        public bool InsertTransaccioneDetail(transaccionesdetaBLL td)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Transacciones_detail (Producto_id, Precio, Cantidad, Total, Prov_Clie_id, added_date, added_by) VALUES (@Producto_id, @Precio, @Cantidad, @Total, @Prov_Clie_id, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Producto_id", td.Producto_id);
                cmd.Parameters.AddWithValue("@Precio", td.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", td.Cantidad);
                cmd.Parameters.AddWithValue("@Total", td.Total);
                cmd.Parameters.AddWithValue("@Prov_Clie_id", td.Prov_Clie_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
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

    }
}
