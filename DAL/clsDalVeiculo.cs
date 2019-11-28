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
    public class clsDalVeiculo : SqlHelper
    {
        public bool InsertVeiculo(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string inserirveiculo = "insert into TB_CD_VEICULO  (ID,PLACA,CHASSI,DESCRICAO,COR_ID,MARCA_ID,MODELO_ID,TIPO_ID,STATUS_ID) " +
                                  " values (" + objVeiculo.Id_vec + ", " + //ver com o Lucas sobre o campo
                                          "'" + objVeiculo.Placa_vec + "', " +
                                          "'" + objVeiculo.Chassi_vec + "', " +
                                          "'"+ objVeiculo.Desc_vec + "'," +
                                                objVeiculo.Corveiculo.Id_cor +","+
                                                objVeiculo.Marcaveiculo.Id_marca+","+
                                                objVeiculo.Tipoveiculo.Id_tipoveiculo +","+
                                                objVeiculo.Statusveiculo.Id_statusveiculo +"); ";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirveiculo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirveiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateVeic(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string atualizarVeiculo = "update TB_CD_VEICULO set PLACA = '" + objVeiculo.Placa_vec + "', " + //CONFEERIR METODO
                                                          " CHASSI = '" + objVeiculo.Chassi_vec + "', " +
                                                          " DESCRICAO = '" + objVeiculo.Desc_vec + "', " +
                                                          " COR_ID = " + objVeiculo.Corveiculo .Id_cor+ ", " +
                                                          " MARCA_ID = " + objVeiculo.Marcaveiculo.Id_marca + ", " +
                                                          " MODELO_ID = " + objVeiculo.Modeloveiculo.Id_modelo + ", " +
                                                          " TIPO_ID = " + objVeiculo.Tipoveiculo.Id_tipoveiculo + ", " +
                                                          " STATUS_ID = " + objVeiculo.Statusveiculo.Id_statusveiculo + ", " +
                                                          " where ID = " + objVeiculo.Id_vec + " ;";//ver com o Lucas ID
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarVeiculo, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarVeiculo, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteVeiculo(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string deletarVeiculo = "delete from TB_CD_VEICULO where ID = " + objVeiculo.Placa_vec + " ;"; //Placa
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
        public clsVeiculo SelectVeiculoId(MySqlConnection conMySql, SqlConnection conServer, clsVeiculo objVeiculo)
        {
            string buscarEstadoId = "select * from TB_CD_VEICULO where PLACA=" + objVeiculo.Placa_vec; //ID%PLACA

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarEstadoId, conServer);
                    dr.Read();
                    objVeiculo.Id_vec = Convert.ToInt32(dr[0].ToString());
                    objVeiculo.Placa_vec = dr[1].ToString();
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                    objVeiculo.Desc_vec = dr[3].ToString();
                    objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                    objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                    objVeiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                    objVeiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                    objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarEstadoId, conMySql);
                    dr.Read();
                    objVeiculo.Id_vec = Convert.ToInt32(dr[0].ToString());
                    objVeiculo.Placa_vec = dr[1].ToString();
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                    objVeiculo.Desc_vec = dr[3].ToString();
                    objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                    objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                    objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                    objVeiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                    objVeiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                    objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                }

                return objVeiculo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsVeiculo> ListVeiculos(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosVeiculos = "select * from TB_CD_VEICULO";
            List<clsVeiculo> listaVeiculos = new List<clsVeiculo>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosVeiculos, conServer);
                    while (dr.Read())
                    {
                        clsVeiculo objVeiculo = new clsVeiculo();
                        objVeiculo.Id_vec = Convert.ToInt32(dr[0].ToString());
                        objVeiculo.Placa_vec = dr[1].ToString();
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                        objVeiculo.Desc_vec = dr[3].ToString();
                        objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                        objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                        objVeiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                        objVeiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                        objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                        listaVeiculos.Add(objVeiculo);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosVeiculos, conMySql);
                    while (dr.Read())
                    {
                        clsVeiculo objVeiculo = new clsVeiculo();
                        objVeiculo.Id_vec = Convert.ToInt32(dr[0].ToString());
                        objVeiculo.Placa_vec = dr[1].ToString();
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[2].ToString());
                        objVeiculo.Desc_vec = dr[3].ToString();
                        objVeiculo.Corveiculo.Id_cor = Convert.ToInt32(dr[4].ToString());
                        objVeiculo.Chassi_vec = Convert.ToInt32(dr[5].ToString());
                        objVeiculo.Marcaveiculo.Id_marca = Convert.ToInt32(dr[6].ToString());
                        objVeiculo.Modeloveiculo.Id_modelo = Convert.ToInt32(dr[7].ToString());
                        objVeiculo.Tipoveiculo.Id_tipoveiculo = Convert.ToInt32(dr[8].ToString());
                        objVeiculo.Statusveiculo.Id_statusveiculo = Convert.ToInt32(dr[9].ToString());
                        listaVeiculos.Add(objVeiculo);
                    }
                }

                return listaVeiculos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
