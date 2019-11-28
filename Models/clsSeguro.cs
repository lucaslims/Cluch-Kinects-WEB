using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsSeguro
    {
        public clsSeguro() {
	}

	private int id_seguro;

	private string desc_seguro;

    public int Id_seguro { get => id_seguro; set => id_seguro = value; }
    public string Desc_seguro { get => desc_seguro; set => desc_seguro = value; }

    public void Seguro() {
		// TODO implement here
	}
    }
}