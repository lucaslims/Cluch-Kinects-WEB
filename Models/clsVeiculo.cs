using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsVeiculo
    {
        public clsVeiculo() {
	}

    private int id_vec;
    private string placa_vec;

    private int chassi_vec;

    private clsCorVeiculo corveiculo;

    private clsMarcaVeiculo marcaveiculo;
            
    private clsModeloVeiculo modeloveiculo;
            
    private clsTipoVeiculo tipoveiculo;
            
    private clsStatusVeiculo statusveiculo;
    private string desc_vec;

    public string Placa_vec { get => placa_vec; set => placa_vec = value; }
    public int Chassi_vec { get => chassi_vec; set => chassi_vec = value; }
    public string Desc_vec { get => desc_vec; set => desc_vec = value; }
    public clsCorVeiculo Corveiculo { get => corveiculo; set => corveiculo = value; }
    public clsMarcaVeiculo Marcaveiculo { get => marcaveiculo; set => marcaveiculo = value; }
    public clsModeloVeiculo Modeloveiculo { get => modeloveiculo; set => modeloveiculo = value; }
    public clsTipoVeiculo Tipoveiculo { get => tipoveiculo; set => tipoveiculo = value; }
    public clsStatusVeiculo Statusveiculo { get => statusveiculo; set => statusveiculo = value; }
    public int Id_vec { get => id_vec; set => id_vec = value; }

    public void Veiculo() {
		// TODO implement here
	}
    }
}