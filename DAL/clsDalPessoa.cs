using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Control;
using System.Data;

namespace DAL
{
    public class clsDalPessoa : SqlHelper
    {
        //Métodos -- executam os comandos SQL
        public bool InsertPessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string inserirPessoa = "insert into tb_cd_pessoa (nome,id_status) " +
                                        "values ('" + objPessoa.Nome + "' , " + objPessoa.StatusPessoa + " );";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirPessoa, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirPessoa, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdatePessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string alterarPessoa = " update tb_cd_pessoa set " +
                                        "     nome = " + objPessoa.Nome +
                                        "     id_status = " + objPessoa.StatusPessoa;
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(alterarPessoa, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(alterarPessoa, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeletePessoa(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string deletarPessoa = "delete from tb_cd_pessoa where id = " + objPessoa.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarPessoa, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarPessoa, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public clsPessoa SelectPessoaId(MySqlConnection conMySql, SqlConnection conServer, clsPessoa objPessoa)
        {
            string buscarPessoaID = "select * from tb_cd_pessoa where id=" + objPessoa.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarPessoaID, conServer);
                    dr.Read();
                    objPessoa.Nome = dr[1].ToString();
                    objPessoa.StatusPessoa = dr[2].ToString();
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarPessoaID, conMySql);
                    dr.Read();
                    objPessoa.Nome = dr[1].ToString();
                    objPessoa.StatusPessoa = dr[2].ToString();
                }

                return objPessoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsPessoa> ListarPessoa(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodasPessoas = "select * from tb_cd_pessoa";
            List<clsPessoa> listaPessoas = new List<clsPessoa>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodasPessoas, conServer);
                    while (dr.Read())
                    {
                        clsPessoa objPessoa = new clsPessoa();
                        objPessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objPessoa.Nome = dr[1].ToString();
                        objPessoa.StatusPessoa = dr[2].ToString();
                        listaPessoas.Add(objPessoa);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodasPessoas, conMySql);
                    while (dr.Read())
                    {
                        clsPessoa objPessoa = new clsPessoa();
                        objPessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objPessoa.Nome = dr[1].ToString();
                        objPessoa.StatusPessoa = dr[2].ToString();
                        listaPessoas.Add(objPessoa);
                    }
                }

                return listaPessoas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
