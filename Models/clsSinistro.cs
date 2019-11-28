using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsSinistro
    {
        public clsSinistro() {
	}

	private int id_sinistro;

	private string desc_acd_sinistro;

	private int total_custo_sinistro;

	private clsVeiculo veiculo;

    public int Id_sinistro { get => id_sinistro; set => id_sinistro = value; }
    public string Desc_acd_sinistro { get => desc_acd_sinistro; set => desc_acd_sinistro = value; }
    public int Total_custo_sinistro { get => total_custo_sinistro; set => total_custo_sinistro = value; }
    public clsVeiculo Veiculo { get => veiculo; set => veiculo = value; }

    private void Sinistro() {
		// TODO implement here
	}
    }
}