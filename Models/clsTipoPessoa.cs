using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsTipoPessoa
    {
        public clsTipoPessoa() {
	}

    private int id;

    public string descricao;

    public int Id { get => id; set => id = value; }
    }
}