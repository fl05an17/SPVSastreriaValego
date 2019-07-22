﻿using SPVSastreriaValego.BLL;
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
    class provclieDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Method from Database
        
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_Prov_Clie";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
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
        #region Insert Method from DataBase
        public bool Insert(provclieBLL pc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Prov_Clie (Tipo, Nombre, Correo, Telefono, Direccion, added_date, added_by) VALUES (@Tipo, @Nombre, @Correo, @Telefono, @Direccion, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Tipo", pc.Tipo);
                cmd.Parameters.AddWithValue("@Nombre", pc.Nombre);
                cmd.Parameters.AddWithValue("@Correo", pc.Correo);
                cmd.Parameters.AddWithValue("@Telefono", pc.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", pc.Direccion);
                cmd.Parameters.AddWithValue("@added_date", pc.added_date);
                cmd.Parameters.AddWithValue("@added_by", pc.added_by);

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
        #region Update Method in Database
        public bool Update(provclieBLL pc)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_Prov_Clie SET Tipo=@Tipo, Nombre=@Nombre, Correo=@Correo, Telefono=@Telefono, Direccion=@Direccion, added_date=@added_date, added_by=@added_by WHERE id=@id";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Tipo", pc.Tipo);
                cmd.Parameters.AddWithValue("@Nombre", pc.Nombre);
                cmd.Parameters.AddWithValue("@Correo", pc.Correo);
                cmd.Parameters.AddWithValue("@Telefono", pc.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", pc.Direccion);
                cmd.Parameters.AddWithValue("@added_date", pc.added_date);
                cmd.Parameters.AddWithValue("@added_by", pc.added_by);
                cmd.Parameters.AddWithValue("@id", pc.id);

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
        #region Delete Method in Database
        public bool Delete(provclieBLL pc)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_Prov_Clie WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", pc.id);

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
                string sql = "SELECT * FROM tbl_Prov_Clie WHERE id LIKE '%" + keywords + "%' OR Tipo LIKE '%" + keywords + "%' OR Nombre LIKE '%" + keywords + "%' OR Correo LIKE '%" + keywords + "%' OR Telefono LIKE '%" + keywords + "%' OR Direccion LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
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

