using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsPais
    {
        public clsPais() {
	}

	private int id;

	private string descricao;
            
	private string abreviacao;

    public int Id { get => id; set => id = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public string Abreviacao { get => abreviacao; set => abreviacao = value; }
    }
}