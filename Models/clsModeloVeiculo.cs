using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsModeloVeiculo
    {
        public clsModeloVeiculo() {
	}

	private int id_modelo;

	private string desc_modelo;

    public int Id_modelo { get => id_modelo; set => id_modelo = value; }
    public string Desc_modelo { get => desc_modelo; set => desc_modelo = value; }

    public void ModeloVeiculo() {
		// TODO implement here
	}
    }
}