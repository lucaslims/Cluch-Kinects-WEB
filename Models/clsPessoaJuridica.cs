using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsPessoaJuridica
    {
        public clsPessoaJuridica() {
	}

	private int id_pessoa_juridica;

	private string inscricao_municipal;

	private string inscricao_estadual;

	private int cnpj;

	private clsPessoa id_Pessoa;

    public int Id_pessoa_juridica { get => id_pessoa_juridica; set => id_pessoa_juridica = value; }
    public string Inscricao_municipal { get => inscricao_municipal; set => inscricao_municipal = value; }
    public string Inscricao_estadual { get => inscricao_estadual; set => inscricao_estadual = value; }
    public int Cnpj { get => cnpj; set => cnpj = value; }
    public clsPessoa Id_Pessoa { get => id_Pessoa; set => id_Pessoa = value; }

    private void PessoaJuridica() {
		// TODO implement here
	}
    }
}