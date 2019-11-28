using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsPessoa
    {
        public clsPessoa()
    {
    }

    private int id;

    private string nome;

    private string statusPessoa;

    public int Id { get => id; set => this.id = value; }
    public string Nome { get => nome; set => this.nome = value; }
    public string StatusPessoa { get => statusPessoa; set => this.statusPessoa = value; }
    }
}