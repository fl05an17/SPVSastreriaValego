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
    class categoriasDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Method
        public DataTable Select()
        {
            //Creating DataBase Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //Writing SQL Query to get all Data from Database 
                string sql = "SELECT * FROM tbl_Categorias";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open DataBase Connection
                conn.Open();

                //Addign the value from adapter to Data Table dt
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
        #region Insert New Category
        public bool Insert(categoriasBLL c)
        {
            //Creating a boolean variable and set its dafault value to false
            bool isSucces = false;

            //Connection to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Writing Query to Add New CAteogry
                string sql = "INSERT INTO tbl_Categorias (Titulo, Descripcion, added_date, added_by) VALUES (@Titulo, @Descripcion, @added_date, @added_by)";
                //Creating SQL command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing Values through parameter
                cmd.Parameters.AddWithValue("@Titulo", c.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

                //Open Database Connection 
                conn.Open();

                //Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed succesfully then its value will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
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
            return isSucces;
        }

        #endregion
        #region Update Method
        public bool Update(categoriasBLL c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_Categorias SET Titulo=@Titulo, Descripcion=@Descripcion, added_date=@added_date, added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Titulo", c.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

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
        #region Delete Method
        public bool Delete(categoriasBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_Categorias WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("id", c.id);

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
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Method for Search Funtionality
        public DataTable Search(string keywords)
        {
            //SQL Connection for database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Creating Data Table to hold th data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //Sql Query ToolBar search categories form database
                String sql = "SELECT * FROM tbl_Categorias WHERE id LIKE '%" + keywords + "%' OR Titulo LIKE '%" + keywords + "%' OR Descripcion LIKE '%" + keywords + "%' ";
                //Creating Sql command to execute the query 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Getting data form database
                SqlDataAdapter adpater = new SqlDataAdapter(cmd);

                //Open databaseConnection
                conn.Open();

                //Passgin values from adpater to data table dt
                adpater.Fill(dt);

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
