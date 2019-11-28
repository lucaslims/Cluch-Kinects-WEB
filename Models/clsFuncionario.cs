using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsFuncionario
    {
        public clsFuncionario() {
	}

	private clsPessoa pessoa;

	private clsCargo cargo;

	private clsDepartamento departamento;

    public clsPessoa Pessoa { get => pessoa; set => pessoa = value; }
    public clsCargo Cargo { get => cargo; set => cargo = value; }
    public clsDepartamento Departamento { get => departamento; set => departamento = value; }

    public void Funcionario() {
		// TODO implement here
	}
    }
}