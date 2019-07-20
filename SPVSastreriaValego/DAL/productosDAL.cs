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
    class productosDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Method for Product Module
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_Productos";

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
        #region Method to insert Product in database
        public bool Insert(productosBLL p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Productos (Nombre, Categoria, Descripcion, Precio, Cantidad, added_date, added_by) VALUES (@Nombre, @Categoria, @Descripcion, @Precio, @Cantidad, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Categoria", p.Categoria);
                cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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
        #region Method Update Product in Database
        public bool Update(productosBLL p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_Productos SET Nombre=@Nombre, Categoria=@Categoria, Descripcion=@Descripcion, Precio=@Precio, added_date=@added_date, added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Categoria", p.Categoria);
                cmd.Parameters.AddWithValue("@Descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", p.Cantidad);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

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
        #region Method Delete Product in Database
        public bool Delete(productosBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_Productos WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", p.id);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            return isSuccess;
        }
        #endregion
        #region Method for search funtionality
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_Productos WHERE id LIKE '%" + keywords + "%' OR Nombre LIKE '%" + keywords + "%' OR Categoria LIKE '%" + keywords + "%' OR Descripcion LIKE '%" + keywords + "%' OR Precio LIKE '%" + keywords + "%' OR Cantidad LIKE '%" + keywords + "%'";
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
