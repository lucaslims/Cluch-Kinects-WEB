using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsEstacionamento
    {
        public clsEstacionamento() {
	}

	private int id;

	private int valor;

	private int quantidade;

	private clsServicos servicos;

    public int Id { get => id; set => id = value; }
    public int Valor { get => valor; set => valor = value; }
    public int Quantidade { get => quantidade; set => quantidade = value; }
    public clsServicos Servicos { get => servicos; set => servicos = value; }
    }
}