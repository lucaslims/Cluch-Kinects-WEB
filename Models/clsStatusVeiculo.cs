using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsStatusVeiculo
    {
        public clsStatusVeiculo() {
	}

	private int id_statusveiculo;

	private string desc_statusveiculo;

    public int Id_statusveiculo { get => id_statusveiculo; set => id_statusveiculo = value; }
    public string Desc_statusveiculo { get => desc_statusveiculo; set => desc_statusveiculo = value; }

    public void StatusVeiculo() {
		// TODO implement here
	}
    }
}