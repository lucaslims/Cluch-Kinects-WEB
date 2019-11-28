using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;
using MySql.Data.MySqlClient;

namespace DAL
{
    class clsDalLogin : SqlHelper
    {

        public bool InsertLogin(MySqlConnection conMySql, SqlConnection conServer, clsLogin objLogin)
        {
            string inserirLogin = "insert into TB_CD_LOGIN (id_pessoa,login,senha,id_tipo_permissao) " +
                                  " values (" + objLogin.Id_pessoa.Id + ", " +
                                          "'" + objLogin.Nome_login + "', " +
                                          "'" + objLogin.Senha_login + "', " +
                                                objLogin.Id_tipo_permissao.Id + " );";

            try
            {
                if (conMySql is null)
                    ExecutarComandoSqlServer(inserirLogin, conServer);
                else if (conServer is null)
                    ExecutarComandoMySql(inserirLogin, conMySql);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateLogin(MySqlConnection conMySql, SqlConnection conServer, clsLogin objLogin)
        {
            string atualizarLogin = "update tb_cd_login set login = '" + objLogin.Nome_login + "' , " +
                                                          " senha = '" + objLogin.Senha_login + "', " +
                                                          " id_tipo_permissao = " + objLogin.Id_tipo_permissao.Id + " " +
                                                          " where id_pessoa = " + objLogin.Id_pessoa.Id + " ;";
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
        public bool DeleteLogin(MySqlConnection conMySql, SqlConnection conServer, clsLogin objLogin)
        {
            string deletarLogin = "delete from TB_CD_LOGIN where id_pessoa = " + objLogin.Id_pessoa.Id + " ;";
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
        public clsLogin SelectLoginId(MySqlConnection conMySql, SqlConnection conServer, clsLogin objLogin)
        {
            string buscarLoginID = "select * from TB_CD_LOGIN where id_pessoa=" + objLogin.Id_pessoa.Id;

            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarLoginID, conServer);
                    dr.Read();
                    objLogin.Id_pessoa.Id = Convert.ToInt32(dr[0].ToString());
                    objLogin.Nome_login = dr[1].ToString();
                    objLogin.Senha_login = dr[2].ToString();
                    objLogin.Id_tipo_permissao.Id = Convert.ToInt32(dr[3].ToString());
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarLoginID, conMySql);
                    dr.Read();
                    objLogin.Id_pessoa.Id = Convert.ToInt32(dr[0].ToString());
                    objLogin.Nome_login = dr[1].ToString();
                    objLogin.Senha_login = dr[2].ToString();
                    objLogin.Id_tipo_permissao.Id = Convert.ToInt32(dr[3].ToString());
                }

                return objLogin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<clsLogin> ListarLogin(MySqlConnection conMySql, SqlConnection conServer)
        {
            string buscarTodosLogins = "select * from TB_CD_LOGIN";
            List<clsLogin> listaLogin = new List<clsLogin>();
            try
            {
                if (conMySql is null)
                {
                    SqlDataReader dr = RetornaDataReaderSqlServer(buscarTodosLogins, conServer);
                    while (dr.Read())
                    {
                        clsLogin objLogin = new clsLogin();
                        objLogin.Id_pessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objLogin.Nome_login = dr[1].ToString();
                        objLogin.Senha_login = dr[2].ToString();
                        objLogin.Id_tipo_permissao.Id = Convert.ToInt32(dr[3].ToString());
                        listaLogin.Add(objLogin);
                    }
                }
                else if (conServer is null)
                {
                    MySqlDataReader dr = RetornaDataReaderMySql(buscarTodosLogins, conMySql);
                    while (dr.Read())
                    {
                        clsLogin objLogin = new clsLogin();
                        objLogin.Id_pessoa.Id = Convert.ToInt32(dr[0].ToString());
                        objLogin.Nome_login = dr[1].ToString();
                        objLogin.Senha_login = dr[2].ToString();
                        objLogin.Id_tipo_permissao.Id = Convert.ToInt32(dr[3].ToString());
                        listaLogin.Add(objLogin);
                    }
                }

                return listaLogin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
        public ComboBox PreencherComboBoxLogin(MySqlConnection conMySql, SqlConnection conServer, ComboBox _comboBox)
        {
            // Pesquisando Logins e guardando no Dataset
            DataTable dt = RetornaDataTable("Select * from tb_cd_login", conMySql, conServer);

            //Limpando a ComboBox
            _comboBox.Items.Clear();

            // For para selecionar linha no datatable e inserir na combobox definida pela função
            for (int r = 0; r < dt.Rows.Count; r++)
                // Comando para adicionar item na combobox definida pela função
                _comboBox.Items.Add(dt.Rows[r]["Nome_login"].ToString());

            // Caso retorne algum dado e seje adicionado na Combobox selecionar índice 0
            if (_comboBox.Items.Count > 0)
                // Comando para selecionar Indice 0
                _comboBox.SelectedIndex = 0;

            // Caso Não retorne nenhum dado adicionar um Item manualmente e selecionar índice 0
            else
            {
                // Comando para adicionar Item no combo
                _comboBox.Items.Add("Selecione um Login");
                // Comando para selecionar Indice 0
                _comboBox.SelectedIndex = 0;
            }

            return _comboBox;
        }
         */

    }
}
