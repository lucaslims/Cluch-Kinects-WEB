using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsLocalizacao
    {
        
	public clsLocalizacao() {
	}

	private int id_loc;

	private string local_loc;
            
	private string desc_loc;

    public int Id_loc { get => id_loc; set => id_loc = value; }
    public string Local_loc { get => local_loc; set => local_loc = value; }
    public string Desc_loc { get => desc_loc; set => desc_loc = value; }
    }
}