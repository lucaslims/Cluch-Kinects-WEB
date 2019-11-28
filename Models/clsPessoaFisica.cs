using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsPessoaFisica
    {
        public clsPessoaFisica() {
	}

	private int pessoa_fisica_CPF;

	private int pessoa_fisica_RG;

	private DateTime pessoa_fisica_dt_nasc;

	private clsCnh cnh;

	private clsPessoa id_pessoa;

    public int Pessoa_fisica_CPF { get => pessoa_fisica_CPF; set => pessoa_fisica_CPF = value; }
    public int Pessoa_fisica_RG { get => pessoa_fisica_RG; set => pessoa_fisica_RG = value; }
    public DateTime Pessoa_fisica_dt_nasc { get => pessoa_fisica_dt_nasc; set => pessoa_fisica_dt_nasc = value; }
    public clsCnh Cnh { get => cnh; set => cnh = value; }
    public clsPessoa Id_pessoa { get => id_pessoa; set => id_pessoa = value; }

    private void PessoaFisica() {
		// TODO implement here
	}
    }
}