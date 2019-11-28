using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DAL
{
    public class clsDalEmail : SqlHelper
    {
        public bool InsertEmail(MySqlConnection conMySql, SqlConnection conServer, clsEmail objEmail)
        {
            string inserirEmail = "insert into TB_CD_PESSOA_EMAIL (id_pessoa,email) " +
                                        "values ('" + objEmail.Pessoa.Id+ "' , " + objEmail.Email + " );";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirEmail, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirEmail, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateEmail(MySqlConnection conMySql, SqlConnection conServer, clsEmail objEmail)
        {
            string alterarEmail = " update TB_CD_PESSOA_EMAIL set " +
                                        "     email = " + objEmail.Email +
                                        "     id_pessoa = " + objEmail.Pessoa.Id;
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(alterarEmail, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(alterarEmail, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteEmail(MySqlConnection conMySql, SqlConnection conServer, clsEmail objEmail)
        {
            string deletarEmail = "delete from TB_CD_PESSOA_EMAIL where ID = " + objEmail.Id + " ;";
            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(deletarEmail, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(deletarEmail, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public clsEmail SelectEmailId(MySqlConnection conMySql, SqlConnection conServer, clsEmail objEmail)
        {
            string buscarLoginID = "select * from TB_CD_PESSOA_EMAIL where id=" + objEmail.Pessoa.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarLoginID, conServer);
                    dr.Read();
                    objEmail.Id = Convert.ToInt32(dr[0].ToString());
                    objEmail.Email = dr[1].ToString();
                    objEmail.Pessoa.Id= Convert.ToInt32(dr[3].ToString());
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarLoginID, conMySql);
                    dr.Read();
                    objEmail.Id= Convert.ToInt32(dr[0].ToString());
                    objEmail.Email = dr[1].ToString();
                    objEmail.Pessoa.Id = Convert.ToInt32(dr[3].ToString());
                }

                return objEmail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsEmail> ListarEmail(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosEmails = "select * from TB_CD_PESSOA_EMAIL";
            List<clsEmail> listaEmail = new List<clsEmail>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosEmails, conServer);
                    while (dr.Read())
                    {
                        clsEmail objEmail = new clsEmail();
                        objEmail.Id = Convert.ToInt32(dr[0].ToString());
                        objEmail.Email = dr[1].ToString();
                        objEmail.Pessoa.Id = Convert.ToInt32(dr[2].ToString());
                        listaEmail.Add(objEmail);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosEmails, conMySql);
                    while (dr.Read())
                    {
                        clsEmail objEmail = new clsEmail();
                        objEmail.Id = Convert.ToInt32(dr[0].ToString());
                        objEmail.Email = dr[1].ToString();

                        objEmail.Pessoa.Id = Convert.ToInt32(dr[2].ToString());
                        listaEmail.Add(objEmail);
                    }
                }

                return listaEmail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
