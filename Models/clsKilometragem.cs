using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsKilometragem
    {
        public clsKilometragem() {
	}

	private int id;

	private int total;

	private clsViagem viagem;

    public int Id { get => id; set => this.id = value; }
    public int Total { get => total; set => total = value; }
    public clsViagem Viagem { get => viagem; set => viagem = value; }
    }
}