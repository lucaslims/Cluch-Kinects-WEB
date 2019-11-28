using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsAbastecimento
    {
    
    public clsAbastecimento() {
	}

	private int id;

	private double preco;

	private int litros;

	private clsViagem viagem;

    public int Id { get => id; set => id = value; }
    public double Preco { get => preco; set => preco = value; }
    public int Litros { get => litros; set => litros = value; }
    public clsViagem Viagem { get => viagem; set => viagem = value; }
}