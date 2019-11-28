using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsTelefone
    {
        public clsTelefone() {
	}

    private int id;

    private clsPessoa pessoa;

    private int ddi;

    private int ddd;

    private int numero;

    public int Id { get => id; set => id = value; }
    public clsPessoa Pessoa { get => pessoa; set => pessoa = value; }
    public int Ddi { get => ddi; set => ddi = value; }
    public int Ddd { get => ddd; set => ddd = value; }
    public int Numero { get => numero; set => numero = value; }
    }
}