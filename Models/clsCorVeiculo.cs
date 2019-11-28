using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsCorVeiculo
    {
        public clsCorVeiculo() {
	}

	private int id_cor;

	private string cor_desc;

    public int Id_cor { get => id_cor; set => id_cor = value; }
    public string Cor_desc { get => cor_desc; set => cor_desc = value; }

    public void CorVeiculo() {
		// TODO implement here
	}
    }

    

}