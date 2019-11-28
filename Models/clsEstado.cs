using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsEstado
    {
        public clsEstado() {
	}

    private int id;

    private String descricao;

    private String abreviacao;

    private clsPais pais;

    private double icms;

    public int Id { get => id; set => id = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public string Abreviacao { get => abreviacao; set => abreviacao = value; }
    public clsPais Pais { get => pais; set => pais = value; }
    public double Icms { get => icms; set => icms = value; }
    }
}