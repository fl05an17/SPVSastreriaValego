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
    class usuariosDAL
    {
        //metodo estatico cadena de conexion a la base de datos.
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Data from Database   
        //la #region se usa para estructurar mejor nuestro codigo (divdirlo en secciones por decir algo)
        public DataTable Select()
        {
            //nuevo objeto de tipo conexionSql
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Objeto tipo Tabla de datos que almacenara los datos de la base de datos temporalmente
            //Mantiene o almacena los datos de la DataBase(DB)
            DataTable dt = new DataTable();

            try
            {
                //cadena para seleccionar todos los datos de la tabla Usuarios
                //Consulta(Query) para obtner datos de la DB
                String sql = "SELECT * FROM tbl_Usuarios";
                //objeto de tipo comandoSql que recibe cadena de consulta y la conexion de donde se va consultar(comando que ejecuta)
                SqlCommand cmd = new SqlCommand(sql, conn);
                //objeto de tipo Adaptador de datos sql obtiene los datos del objeto cmd (para adaptar a la DataTable)
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //abre la conexion a la base de datos
                conn.Open();
                //Llena los datos en la DataTable
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                //muestra algun mensaje si hay algun error en nuestro codigo
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //cierra la conexion
                conn.Close();
            }
            //Returna el valor en la DataTable
            return dt;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(usuariosBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "INSERT INTO tbl_Usuarios (Nombre, Apellido, Correo, NombreUsuario, " +
                    "Contraseña, Telefono, Direccion, Genero, TipodeUsuario, added_date, added_by) " +
                    "VALUES (@Nombre, @Apellido, @Correo, @NombreUsuario, @Contraseña, @Telefono, " +
                    "@Direccion, @Genero, @TipodeUsuario, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", u.Apellido);
                cmd.Parameters.AddWithValue("@Correo", u.Correo);
                cmd.Parameters.AddWithValue("@NombreUsuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", u.Contraseña);
                cmd.Parameters.AddWithValue("@Telefono", u.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", u.Direccion);
                cmd.Parameters.AddWithValue("@Genero", u.Genero);
                cmd.Parameters.AddWithValue("@TipodeUsuario", u.TipodeUsuario);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();

                //rows = filas
                int rows = cmd.ExecuteNonQuery();

                //Si la consulta es ejecutada con exito entonces el valor de las filas sera mayor a 0, sino sera menor que 0
                if (rows > 0)
                {
                    //Consulta exitosa
                    isSuccess = true;
                }
                else
                {
                    //Consulta fallo
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

        #region Update Data in Database
        public bool Update(usuariosBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_Usuarios SET Nombre=@Nombre, Apellido=@Apellido, Correo=@Correo, NombreUsuario=@NombreUsuario, " +
                    "Contraseña=@Contraseña, Telefono=@Telefono, Direccion=@Direccion, Genero=@Genero, " +
                    "TipodeUsuario=@TipodeUsuario, added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", u.Apellido);
                cmd.Parameters.AddWithValue("@Correo", u.Correo);
                cmd.Parameters.AddWithValue("@NombreUsuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", u.Contraseña);
                cmd.Parameters.AddWithValue("@Telefono", u.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", u.Direccion);
                cmd.Parameters.AddWithValue("@Genero", u.Genero);
                cmd.Parameters.AddWithValue("@TipodeUsuario", u.TipodeUsuario);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();                
                int rows = cmd.ExecuteNonQuery();                
                if (rows > 0)
                {
                    //Consulta exitosa
                    isSuccess = true;
                }
                else
                {
                    //Consulta fallo
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

        #region Delete Data in Database
        public bool Delete(usuariosBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_Usuarios WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //consulta exitosa
                    isSuccess = true;
                }
                else
                {
                    //consulta fallida
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
    }
}
