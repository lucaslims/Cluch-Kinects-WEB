using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsTipoPermissao
    {
        public clsTipoPermissao() {
	}

	private int id;

	private string descricao;

    public int Id { get => id; set => id = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    }
}