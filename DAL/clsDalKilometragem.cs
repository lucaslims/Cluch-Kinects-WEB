using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class clsDalKilometragem
    {
        public bool InsertFuncionario(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFunc)
        {
            string inserirFuncionario = "insert into TB_CD_FUNCIONARIO  (ID_PESSOA,DEPARTAMENTO,CARGO " +
                                  " values (" + objFunc.Pessoa.Id + ", " +
                                          "'" + objFunc.Departamento.Id + "', " +
                                          "'" + objFunc.Cargo.Id + ");";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirFuncionario, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirFuncionario, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateFuncionario(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFunc)
        {
            string atualizarFuncionario = "update TB_CD_FUNCIONARIO set ID_PESSOA = '" + objFunc.Pessoa.Id + "' , " +
                                                          " DEPARTAMENTO = '" + objFunc.Departamento.Id + "', " +
                                                          " CARGO = " + objFunc.Cargo.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(atualizarFuncionario, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(atualizarFuncionario, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteFuncionario(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFunc)
        {
            string deletarFuncionario = "delete from TB_CD_FUNCIONARIO where ID_PESSOA = " + objFunc.Pessoa.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarFuncionario, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarFuncionario, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsFuncionario SelectFuncId(MySqlConnection conMySql, SqlConnection conServer, clsFuncionario objFun)
        {
            string buscarFuncionarioId = "select * from TB_CD_FUNCIONARIO where ID_PESSOA=" + objFun.Pessoa.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarFuncionarioId, conServer);
                    dr.Read();
                    objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                    objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                    objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());

                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarFuncionarioId, conMySql);
                    dr.Read();
                    objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                    objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                    objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());

                }

                return objFun;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsFuncionario> ListFuncionario(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosFuncionarios = "select * from TB_CD_FUNCIONARIO";
            List<clsFuncionario> ListaFuncionario = new List<clsFuncionario>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosFuncionarios, conServer);
                    while (dr.Read())
                    {
                        clsFuncionario objFun = new clsFuncionario();
                        objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                        objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());
                        ListaFuncionario.Add(objFun);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosFuncionarios, conMySql);
                    while (dr.Read())
                    {
                        clsFuncionario objFun = new clsFuncionario();
                        objFun.Pessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objFun.Departamento.Id = Convert.ToInt32(dr[1].ToString());
                        objFun.Cargo.Id = Convert.ToInt32(dr[2].ToString());
                        ListaFuncionario.Add(objFun);
                    }
                }

                return ListaFuncionario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

