using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsLogAcessos
    {
        public clsLogAcessos() {
	}

	private int id;

	private clsPessoa id_pessoa;

	private DateTime datahora;

	private string usuario;

    public int Id { get => id; set => id = value; }
    public clsPessoa Id_pessoa { get => id_pessoa; set => id_pessoa = value; }
    public DateTime Datahora { get => datahora; set => datahora = value; }
    public string Usuario { get => usuario; set => usuario = value; }
    }
}