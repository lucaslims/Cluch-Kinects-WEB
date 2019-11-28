using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsLogin
    {
        public clsLogin() {
	}

	private clsPessoa id_pessoa;

	private string nome_login;

	private string senha_login;

    private clsTipoPermissao id_tipo_permissao;

    public clsPessoa Id_pessoa { get => id_pessoa; set => id_pessoa = value; }
    public string Nome_login { get => nome_login; set => nome_login = value; }
    public string Senha_login { get => senha_login; set => senha_login = value; }
    public clsTipoPermissao Id_tipo_permissao { get => id_tipo_permissao; set => id_tipo_permissao = value; }

    public void Login() {
		// TODO implement here
	}
    }
}