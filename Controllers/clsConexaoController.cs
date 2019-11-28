using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Devart.Data.MySql;

namespace Clutch_Pim.Controllers
{
    public class clsConexaoController : Controller
    {
        private static SqlConnection con;

        private static MySqlConnection conn;

        // private static string caminhoSqlServer = @"Server=L1M25;Database=BD_POOII;User Id= redes; Password=alpha";
        private static string caminhoSqlServer = @"Data Source = L1M25; Initial catalog = bd_clutch_kinetics; Integrated Security = True";

        private static string caminhoMySql = @"server=mysqlconnectionaws.cfc2tcexvysf.sa-east-1.rds.amazonaws.com; database=CLUCTCH_KINETICS uid=admin; password=";

        public static SqlConnection GetConexaoSqlServer()
        {
            try
            {
                con = new SqlConnection(caminhoSqlServer);
                return con;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MySqlConnection GetConexaoMySql()
        {
            try
            {
                conn = new MySqlConnection(caminhoMySql);
                return conn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
