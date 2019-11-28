using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsCidade
    {

    private int id;

    private string descricao;

    private clsEstado estado;

    private double iss;

    public int Id { get => id; set => id = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public clsEstado Estado { get => estado; set => estado = value; }
    public double Iss { get => iss; set => iss = value; }
    }
}