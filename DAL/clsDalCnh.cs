using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Control;

namespace DAL
{
    class clsDalCnh:SqlHelper
    {
        public bool InsertCnh(MySqlConnection conMySql, SqlConnection conServer, clsCnh objcnh)
        {
            string InserirCnh = "insert into TB_CNH  (CNH_ID,NUMERO,CATEGORIA,CNH_DT,VALIDADE " +
                                  " values (" + objcnh.Id_CNH + ", " +
                                          "'" + objcnh.Num_CNH +","+
                                          objcnh.Categoria_CNH+","+
                                          objcnh.Dt_validade_CNH+");";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(InserirCnh, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(InserirCnh, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateCnh(MySqlConnection conMySql, SqlConnection conServer, clsCnh objcnh)
        {
            string atualizarCnh = "update TB_CNH set CNH_ID = '" + objcnh.Id_CNH + "' , " +
                                                          "NUMERO = "+objcnh.Num_CNH+" ,"+
                                                          " CATEGORIA = '" + objcnh.Categoria_CNH + ","+
                                                          "CNH_DT_VALIDADE = "+ objcnh.Dt_validade_CNH+";";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarCnh, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarCnh, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteCnh(MySqlConnection conMySql, SqlConnection conServer, clsCnh objcnh)
        {
            string deletarCNH = "delete from TB_CNH where CNH_ID = " + objcnh.Id_CNH + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarCNH, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarCNH, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsCnh SelectCnhId(MySqlConnection conMySql, SqlConnection conServer, clsCnh objcnh)
        {
            string buscarCnhPeloId = "select * from TB_CNH where ID=" + objcnh.Id_CNH;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarCnhPeloId, conServer);
                    dr.Read();
                    objcnh.Id_CNH = Convert.ToInt32(dr[0].ToString());
                    objcnh.Num_CNH = Convert.ToInt32(dr[1].ToString());
                    objcnh.Categoria_CNH = dr[2].ToString();
                    objcnh.Dt_validade_CNH =Convert.ToDateTime( dr[3].ToString());


                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarCnhPeloId, conMySql);
                    dr.Read();
                    objcnh.Id_CNH = Convert.ToInt32(dr[0].ToString());
                    objcnh.Num_CNH = Convert.ToInt32(dr[1].ToString());
                    objcnh.Categoria_CNH = dr[2].ToString();
                    objcnh.Dt_validade_CNH = Convert.ToDateTime(dr[3].ToString());


                }

                return objcnh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsCnh> ListCnhId(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasCnh = "select * from TB_CNH";
            List<clsCnh> ListaCnh = new List<clsCnh>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasCnh, conServer);
                    while (dr.Read())
                    {
                        clsCnh objcnh = new clsCnh();
                        objcnh.Id_CNH = Convert.ToInt32(dr[0].ToString());
                        objcnh.Num_CNH = Convert.ToInt32(dr[1].ToString());
                        objcnh.Categoria_CNH = dr[2].ToString();
                        objcnh.Dt_validade_CNH = Convert.ToDateTime(dr[3].ToString());
                        ListaCnh.Add(objcnh);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasCnh, conMySql);
                    while (dr.Read())
                    {
                        clsCnh objcnh = new clsCnh();
                        objcnh.Id_CNH = Convert.ToInt32(dr[0].ToString());
                        objcnh.Num_CNH = Convert.ToInt32(dr[1].ToString());
                        objcnh.Categoria_CNH = dr[2].ToString();
                        objcnh.Dt_validade_CNH = Convert.ToDateTime(dr[3].ToString());
                        ListaCnh.Add(objcnh);
                    }
                }


                return ListaCnh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}