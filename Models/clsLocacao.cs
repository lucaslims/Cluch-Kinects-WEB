using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsLocacao
    {
        public clsLocacao() {
	}

	private int id_locacao;

	private DateTime dt_loc;

	private DateTime dt_tempo_loc;

	private double custo_loc;

	private double taxa_extra_loc;

	private clsSeguro seguro;

	private clsPessoa cliente;

	private clsVeiculo veiculo;

    public int Id_locacao { get => id_locacao; set => id_locacao = value; }
    public DateTime Dt_loc { get => dt_loc; set => dt_loc = value; }
    public DateTime Dt_tempo_loc { get => dt_tempo_loc; set => dt_tempo_loc = value; }
    public double Custo_loc { get => custo_loc; set => custo_loc = value; }
    public double Taxa_extra_loc { get => taxa_extra_loc; set => taxa_extra_loc = value; }
    public clsSeguro Seguro { get => seguro; set => seguro = value; }
    public clsPessoa Cliente { get => cliente; set => this.cliente = value; }
    public clsVeiculo Veiculo { get => veiculo; set => veiculo = value; }
    }
}