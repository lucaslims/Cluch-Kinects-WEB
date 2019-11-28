using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsCnh
    {
        
        public clsCnh() {
	}

	private int id_CNH;

	private int num_CNH;

	private string categoria_CNH;

	private DateTime dt_validade_CNH;

    public int Id_CNH { get => id_CNH; set => id_CNH = value; }
    public int Num_CNH { get => num_CNH; set => num_CNH = value; }
    public string Categoria_CNH { get => categoria_CNH; set => categoria_CNH = value; }
    public DateTime Dt_validade_CNH { get => dt_validade_CNH; set => dt_validade_CNH = value; }

    public void Cnh() {
		// TODO implement here
	}
	}

    

}