using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsViagem
    {
        public clsViagem() {
	}

	private int id_viagem;

	private string origem_viagem;

	private String destino_viagem;

	private clsVeiculo veiculo;

	private clsServicos servico;

    public int Id_viagem { get => id_viagem; set => id_viagem = value; }
    public string Origem_viagem { get => origem_viagem; set => origem_viagem = value; }
    public string Destino_viagem { get => destino_viagem; set => destino_viagem = value; }
    public clsVeiculo Veiculo { get => veiculo; set => veiculo = value; }
    public clsServicos Servico { get => servico; set => servico = value; }

    public void Viagem() {
		// TODO implement here
	}
    }
}