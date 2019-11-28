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
    class clsDalLocacao :SqlHelper
    {
        
            public bool InsertLocacao(MySqlConnection conMySql, SqlConnection conServer, clsLocacao objLocacao)
            {
            string inserirLocacao = "insert into TB_NG_LOCACAO  (ID,DT_LOC,TEMPO_LOC,CUSTO,TAXA_EXTRA,SEGURO_ID,PESSOA_ID,VEICULO_ID) " +
                                  " values (" + objLocacao.Id_locacao + ", " + //ver com o Lucas sobre o campo
                                          "" + objLocacao.Dt_loc + ", " +
                                          "" + objLocacao.Dt_tempo_loc + ", " +
                                          "" + objLocacao.Custo_loc + "," +
                                                objLocacao.Taxa_extra_loc + "," +
                                                objLocacao.Seguro.Id_seguro + "," +
                                                objLocacao.Cliente.Id + "," +
                                                objLocacao.Veiculo.Id_vec + "); ";

                try
                {
                    if (conMySql is null)
                        ExecutarComandoSqlServer(inserirLocacao, conServer);
                    else if (conServer is null)
                        ExecutarComandoMySql(inserirLocacao, conMySql);

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public bool UpdateLocacao(MySqlConnection conMySql, SqlConnection conServer, clsLocacao objLocacao)
            {
                string atualizarLocacao = "update TB_NG_LOCACAO set ID = '" + objLocacao.Id_locacao + "', " +
                                                              " CHASSI = '" + objLocacao.Dt_loc + "', " +
                                                              " DESCRICAO = '" + objLocacao.Dt_tempo_loc + "', " +
                                                              " COR_ID = " + objLocacao.Custo_loc + ", " +
                                                              " MARCA_ID = " + objLocacao.Taxa_extra_loc + ", " +
                                                              " MODELO_ID = " + objLocacao.Seguro.Id_seguro + ", " +
                                                              " TIPO_ID = " + objLocacao.Cliente.Id + ", " +
                                                              " STATUS_ID = " + objLocacao.Veiculo.Id_vec + ", " +
                                                              " where ID = " + objLocacao.Id_locacao + " ;";
                try
                {
                    if (conMySql is null)
                        ExecutarComandoSqlServer(atualizarLocacao, conServer);
                    else if (conServer is null)
                        ExecutarComandoMySql(atualizarLocacao, conMySql);

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            public bool DeleteVeiculo(MySqlConnection conMySql, SqlConnection conServer, clsLocacao objLocacao)
            {
                string deletarVeiculo = "delete from TB_NG_LOCACAO where ID = " + objLocacao.Id_locacao + " ;"; //Placa
                try
                {
                    if (conMySql is null)
                        ExecutarComandoSqlServer(deletarVeiculo, conServer);
                    else if (conServer is null)
                        ExecutarComandoMySql(deletarVeiculo, conMySql);

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public clsLocacao SelectVeiculoId(MySqlConnection conMySql, SqlConnection conServer, clsLocacao objLocacao)
            {
                string buscarLocacaoId = "select * from TB_NG_LOCACAO where ID=" + objLocacao.Id_locacao; 

                try
                {
                    if (conMySql is null)
                    {
                        SqlDataReader dr = RetornaDataReaderSqlServer(buscarLocacaoId, conServer);
                        dr.Read();
                    objLocacao.Id_locacao = Convert.ToInt32(dr[0].ToString());
                    objLocacao.Dt_loc = Convert.ToDateTime(dr[1].ToString());
                    objLocacao.Dt_tempo_loc = Convert.ToDateTime(dr[2].ToString()); //SMALL INT
                    objLocacao.Custo_loc = Convert.ToDouble(dr[3].ToString());
                    objLocacao.Taxa_extra_loc = Convert.ToDouble(dr[4].ToString());
                    objLocacao.Seguro.Id_seguro = Convert.ToInt32(dr[5].ToString());
                    objLocacao.Cliente.Id = Convert.ToInt32(dr[6].ToString());
                    objLocacao.Veiculo.Id_vec = Convert.ToInt32(dr[7].ToString());
                    
                    }
                    else if (conServer is null)
                    {
                        MySqlDataReader dr = RetornaDataReaderMySql(buscarLocacaoId, conMySql);
                        dr.Read();
                    objLocacao.Id_locacao = Convert.ToInt32(dr[0].ToString());
                    objLocacao.Dt_loc = Convert.ToDateTime(dr[1].ToString());
                    objLocacao.Dt_tempo_loc = Convert.ToDateTime(dr[2].ToString()); //SMALL INT
                    objLocacao.Custo_loc = Convert.ToDouble(dr[3].ToString());
                    objLocacao.Taxa_extra_loc = Convert.ToDouble(dr[4].ToString());
                    objLocacao.Seguro.Id_seguro = Convert.ToInt32(dr[5].ToString());
                    objLocacao.Cliente.Id = Convert.ToInt32(dr[6].ToString());
                    objLocacao.Veiculo.Id_vec = Convert.ToInt32(dr[7].ToString());
                }

                    return objLocacao;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public List<clsLocacao> ListLocacao(MySqlConnection conMySql, SqlConnection conServer)
            {
                string buscarTodasLocacoes = "select * from TB_NG_LOCACAO";
                List<clsLocacao> listaLocacao = new List<clsLocacao>();
                try
                {
                    if (conMySql is null)
                    {
                        SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasLocacoes, conServer);
                        while (dr.Read())
                        {
                            clsLocacao objLocacao = new clsLocacao();
                        objLocacao.Id_locacao = Convert.ToInt32(dr[0].ToString());
                        objLocacao.Dt_loc = Convert.ToDateTime(dr[1].ToString());
                        objLocacao.Dt_tempo_loc = Convert.ToDateTime(dr[2].ToString()); //SMALL INT
                        objLocacao.Custo_loc = Convert.ToDouble(dr[3].ToString());
                        objLocacao.Taxa_extra_loc = Convert.ToDouble(dr[4].ToString());
                        objLocacao.Seguro.Id_seguro = Convert.ToInt32(dr[5].ToString());
                        objLocacao.Cliente.Id = Convert.ToInt32(dr[6].ToString());
                        objLocacao.Veiculo.Id_vec = Convert.ToInt32(dr[7].ToString());
                        listaLocacao.Add(objLocacao);
                        }
                    }
                    else if (conServer is null)
                    {
                        MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasLocacoes, conMySql);
                        while (dr.Read())
                        {
                        clsLocacao objLocacao = new clsLocacao();
                        objLocacao.Id_locacao = Convert.ToInt32(dr[0].ToString());
                        objLocacao.Dt_loc = Convert.ToDateTime(dr[1].ToString());
                        objLocacao.Dt_tempo_loc = Convert.ToDateTime(dr[2].ToString()); //SMALL INT
                        objLocacao.Custo_loc = Convert.ToDouble(dr[3].ToString());
                        objLocacao.Taxa_extra_loc = Convert.ToDouble(dr[4].ToString());
                        objLocacao.Seguro.Id_seguro = Convert.ToInt32(dr[5].ToString());
                        objLocacao.Cliente.Id = Convert.ToInt32(dr[6].ToString());
                        objLocacao.Veiculo.Id_vec = Convert.ToInt32(dr[7].ToString());
                        listaLocacao.Add(objLocacao);
                        }
                    }

                    return listaLocacao;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
