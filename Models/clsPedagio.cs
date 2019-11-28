using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsPedagio
    {
        public clsPedagio() {
	}

	private int id;

	private double valor;

	private int quantidade;

	private clsServicos servicos;

    public int Id { get => id; set => id = value; }
    public double Valor { get => valor; set => valor = value; }
    public int Quantidade { get => quantidade; set => quantidade = value; }
    public clsServicos Servicos { get => servicos; set => servicos = value; }
    }
}