using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsTipoVeiculo
    {
        public clsTipoVeiculo() {
	}

	private int id_tipoveiculo;

	private string desc_tipoveiculo;

    public int Id_tipoveiculo { get => id_tipoveiculo; set => id_tipoveiculo = value; }
    public string Desc_tipoveiculo { get => desc_tipoveiculo; set => desc_tipoveiculo = value; }

    public void TipoVeiculo() {
		// TODO implement here
	}
    }
}