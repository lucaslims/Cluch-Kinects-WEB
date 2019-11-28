using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Control;
using System.Data.SqlClient;

namespace DAL
{
    class clsDalEstado:SqlHelper
    {
        public bool InsertEstado(MySqlConnection conMySql, SqlConnection conServer, clsEstado objEstado)
        {
            string inserirEstado = "insert into TB_CD_ESTADO  (id,descricao,ABREVIACAO,ID_PAIS, ICMS) " +
                                  " values (" + objEstado.Id + ", " +
                                          "'" + objEstado.Descricao + "', " +
                                          "'" + objEstado.Abreviacao + "', " +
                                                objEstado.Pais.Id + "','+" +
                                                objEstado.Icms+");";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirEstado, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirEstado, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateEstado(MySqlConnection conMySql, SqlConnection conServer, clsEstado objEstado)
        {
            string atualizarLogin = "update TB_CD_ESTADO set ID = '" + objEstado.Id + "' , " +
                                                          " DESCRICAO = '" + objEstado.Descricao + "', " +
                                                          " ABREVIACAO = " + objEstado.Abreviacao + ", " +
                                                          " ICMS = " + objEstado.Icms+", "+
                                                          " where id_pais = "+ objEstado.Pais.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarLogin, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarLogin, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteEstado(MySqlConnection conMySql, SqlConnection conServer, clsEstado objEstado)
        {
            string deletarLogin = "delete from TB_CD_ESTADO where id_pais = " + objEstado.Pais.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarLogin, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarLogin, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsEstado SelectEstadoId(MySqlConnection conMySql, SqlConnection conServer, clsEstado objEstado)
        {
            string buscarEstadoId = "select * from TB_CD_ESTADO where id_pais=" + objEstado.Pais.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarEstadoId, conServer);
                    dr.Read();
                    objEstado.Id = Convert.ToInt32(dr[0].ToString());
                    objEstado.Descricao = dr[1].ToString();
                    objEstado.Abreviacao = dr[2].ToString();
                    objEstado.Pais.Id = Convert.ToInt32(dr[3].ToString());
                    objEstado.Icms = Convert.ToDouble(dr[4].ToString());
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarEstadoId, conMySql);
                    dr.Read();
                    objEstado.Id = Convert.ToInt32(dr[0].ToString());
                    objEstado.Descricao = dr[1].ToString();
                    objEstado.Abreviacao = dr[2].ToString();
                    objEstado.Pais.Id = Convert.ToInt32(dr[3].ToString());
                    objEstado.Icms = Convert.ToDouble(dr[4].ToString());
                }

                return objEstado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsEstado> ListarEstados(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosEstados = "select * from TB_CD_ESTADO";
            List<clsEstado> listaEstado = new List<clsEstado>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosEstados, conServer);
                    while (dr.Read())
                    {
                        clsEstado objEstado = new clsEstado();
                        objEstado.Id = Convert.ToInt32(dr[0].ToString());
                        objEstado.Descricao = dr[1].ToString();
                        objEstado.Abreviacao = dr[2].ToString();
                        objEstado.Pais.Id = Convert.ToInt32(dr[3].ToString());
                        objEstado.Icms = Convert.ToDouble(dr[4].ToString());
                        listaEstado.Add(objEstado);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosEstados, conMySql);
                    while (dr.Read())
                    {
                        clsEstado objEstado = new clsEstado();
                        objEstado.Id = Convert.ToInt32(dr[0].ToString());
                        objEstado.Descricao = dr[1].ToString();
                        objEstado.Abreviacao = dr[2].ToString();
                        objEstado.Pais.Id = Convert.ToInt32(dr[3].ToString());
                        objEstado.Icms = Convert.ToDouble(dr[4].ToString());
                        listaEstado.Add(objEstado);
                    }
                }

                return listaEstado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
