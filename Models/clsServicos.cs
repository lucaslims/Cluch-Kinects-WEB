using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsServicos
    {
        public clsServicos() {
	}

	private int id_servicos;

	private double total_pedagio;

	private double total_estacionamento;

    public int Id_servicos { get => id_servicos; set => id_servicos = value; }
    public double Total_pedagio { get => total_pedagio; set => total_pedagio = value; }
    public double Total_estacionamento { get => total_estacionamento; set => total_estacionamento = value; }

    public void Servicos() {
		// TODO implement here
	}
    }
}