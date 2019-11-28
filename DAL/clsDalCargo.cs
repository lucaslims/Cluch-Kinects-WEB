using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Devart.Data.MySql;
using Control;


namespace Clutch_Pim.DAL
{
    public class clsDalCargo:SqlHelper
    {
        public bool InsertCargo(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string InserirCargo = "insert into TB_CD_CARGO  (ID,DESCRICAO " +
                                  " values (" + objCargo.Id + ", " +
                                          "'" + objCargo.Descricao +");";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(InserirCargo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(InserirCargo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateCargo(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string atualizarCargo = "update TB_CD_CARGO set ID = '" + objCargo.Id + "' , " +
                                                          " DESCRICAO = '" + objCargo.Descricao + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarCargo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarCargo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteCargo(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string deletarCargo = "delete from TB_CD_CARGO where ID = " + objCargo.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarCargo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarCargo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsCargo SelectCargoId(MySqlConnection conMySql, SqlConnection conServer, clsCargo objCargo)
        {
            string buscarCargoPeloId = "select * from TB_CD_CARGO where ID=" + objCargo.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarCargoPeloId, conServer);
                    dr.Read();
                    objCargo.Id = Convert.ToInt32(dr[0].ToString());
                    objCargo.Descricao = dr[1].ToString();
               

                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarCargoPeloId, conMySql);
                    dr.Read();
                    objCargo.Id = Convert.ToInt32(dr[0].ToString());
                    objCargo.Descricao = dr[1].ToString();

                }

                return objCargo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsCargo> ListCargosId(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosCargos = "select * from TB_CD_FUNCIONARIO";
            List<clsCargo> ListaCargo = new List<clsCargo>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosCargos, conServer);
                    while (dr.Read())
                    {
                        clsCargo objCargo = new clsCargo();
                        objCargo.Id = Convert.ToInt32(dr[0].ToString());
                        objCargo.Descricao = dr[1].ToString();
                        ListaCargo.Add(objCargo);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosCargos, conMySql);
                    while (dr.Read())
                    {
                        clsCargo objCargo = new clsCargo();
                        objCargo.Id = Convert.ToInt32(dr[0].ToString());
                        objCargo.Descricao = dr[1].ToString();
                        ListaCargo.Add(objCargo);
                    }
                }
                

                return ListaCargo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}