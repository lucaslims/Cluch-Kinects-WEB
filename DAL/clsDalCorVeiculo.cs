using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Control;

namespace DAL
{
    class clsDalCorVeiculo:SqlHelper
    {
        public bool InsertCorVeiculo(MySqlConnection conMySql, SqlConnection conServer,clsCorVeiculo objCorVeic)
        {
            string InserirCorVeiculo = "insert into TB_CD_VEICULO_COR  (ID,DESCRICAO " +
                                  " values (" + objCorVeic.Id_cor + ", " +
                                          "'" + objCorVeic.Cor_desc + "');";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(InserirCorVeiculo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(InserirCorVeiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateCorVeic(MySqlConnection conMySql, SqlConnection conServer, clsCorVeiculo objCorVei)
        {
            string atualizarCorVeiculo = "update TB_CD_VEICULO_COR set ID = '" + objCorVei.Id_cor + "' , " +
                                                          " DESCRICAO = '" + objCorVei.Cor_desc + " ';";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarCorVeiculo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarCorVeiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteCorVeic(MySqlConnection conMySql, SqlConnection conServer, clsCorVeiculo objCorVei)
        {
            string deletarCorVeiculo = "delete from TB_CD_VEICULO_COR where ID = " + objCorVei.Id_cor + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarCorVeiculo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarCorVeiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsCorVeiculo SelectCorVeic(MySqlConnection conMySql, SqlConnection conServer, clsCorVeiculo objCorVeio)
        {
            string BuscarCorPeloId = "select * from TB_CD_VEICULO_COR where ID=" + objCorVeio.Id_cor;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(BuscarCorPeloId, conServer);
                    dr.Read();
                    objCorVeio.Id_cor = Convert.ToInt32(dr[0].ToString());
                    objCorVeio.Cor_desc = dr[1].ToString();


                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(BuscarCorPeloId, conMySql);
                    dr.Read();
                    objCorVeio.Id_cor = Convert.ToInt32(dr[0].ToString());
                    objCorVeio.Cor_desc = dr[1].ToString();

                }

                return objCorVeio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsCorVeiculo> ListCorVeicId(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasCores = "select * from TB_CD_VEICULO_COR";
            List<clsCorVeiculo> ListCorVeiculo = new List<clsCorVeiculo>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasCores, conServer);
                    while (dr.Read())
                    {
                        clsCorVeiculo objCorVeic = new clsCorVeiculo();
                        objCorVeic.Id_cor = Convert.ToInt32(dr[0].ToString());
                        objCorVeic.Cor_desc = dr[1].ToString();
                        ListCorVeiculo.Add(objCorVeic);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasCores, conMySql);
                    while (dr.Read())
                    {
                        clsCorVeiculo objCorVeic = new clsCorVeiculo();
                        objCorVeic.Id_cor = Convert.ToInt32(dr[0].ToString());
                        objCorVeic.Cor_desc = dr[1].ToString();
                        ListCorVeiculo.Add(objCorVeic);
                    }
                }
                


                return ListCorVeiculo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

