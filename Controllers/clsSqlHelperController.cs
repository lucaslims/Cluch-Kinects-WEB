using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using Devart.Data.MySql;


namespace Clutch_Pim.Controllers
{
    public class clsSqlHelperController : Controller
    {// Conexão MySql
        public void AbrirConexaoMySql(MySqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void FecharConexaoMySql(MySqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MySqlDataReader RetornaDataReaderMySql(string comando, MySqlConnection con)
        {
            try
            {
                MySqlDataReader dr;
                MySqlCommand cmd = new MySqlCommand(comando, con);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable RetornaDataTableMySql(string comando, MySqlConnection con)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(comando, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet RetornaDataSetMySql(string comando, MySqlConnection con)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlCommand cmd = new MySqlCommand(comando, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExecutarComandoMySql(string comando, MySqlConnection con)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExecutarComandoRetornoMySql(string comando, MySqlConnection con)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = comando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "SELECT ";
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Conexão Com MySql ou SqlServer
        public DataTable RetornaDataTable(string comando, MySqlConnection conMySql, SqlConnection conSqlServer)
        {
            try
            {
                DataTable dt = new DataTable();

                if (conSqlServer is null)
                {
                    MySqlCommand cmd = new MySqlCommand(comando, conMySql);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                else if (conMySql is null)
                {
                    SqlCommand cmd = new SqlCommand(comando, conSqlServer);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet RetornaDataSet(string comando, MySqlConnection conMySql, SqlConnection conSqlServer)
        {
            try
            {
                DataSet ds = new DataSet();
                if (conSqlServer is null)
                {
                    MySqlCommand cmd = new MySqlCommand(comando, conMySql);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ds);
                }
                else if (conMySql is null)
                {
                    SqlCommand cmd = new SqlCommand(comando, conSqlServer);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExecutarComando(string comando, MySqlConnection conMySql, SqlConnection conSqlServer)
        {
            try
            {
                if (conSqlServer is null)
                {
                    MySqlCommand cmd = new MySqlCommand(comando, conMySql);
                    cmd.ExecuteNonQuery();
                }
                else if (conMySql is null)
                {
                    SqlCommand cmd = new SqlCommand(comando, conSqlServer);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExecutarComandoRetorno(string comando, MySqlConnection conMySql, SqlConnection conSqlServer)
        {
            try
            {
                if (conSqlServer is null)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = comando;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conMySql;
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "SELECT @@IDENTITY";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return Convert.ToInt32(dr[0]);
                }
                if (conMySql is null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = comando;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conSqlServer;
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "SELECT @@IDENTITY";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return Convert.ToInt32(dr[0]);
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Conexão SqlServer
        public void AbrirConexaoSqlServer(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void FecharConexaoSqlServer(SqlConnection con)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader RetornaDataReaderSqlServer(string comando, SqlConnection con)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand(comando, con);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable RetornaDataTableSqlServer(string comando, SqlConnection con)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(comando, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet RetornaDataSetSqlServer(string comando, SqlConnection con)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(comando, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExecutarComandoSqlServer(string comando, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExecutarComandoRetornoSqlServer(string comando, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = comando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
