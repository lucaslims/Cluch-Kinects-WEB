using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsMarcaVeiculo
    {
        public clsMarcaVeiculo() {
	}

	private int id_marca;

	private string desc_marca;

    public int Id_marca { get => id_marca; set => id_marca = value; }
    public string Desc_marca { get => desc_marca; set => desc_marca = value; }

    public void MarcaVeiculo() {
		// TODO implement here
	}
    }
}