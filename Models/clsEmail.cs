using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clutch_Pim.Models
{
    public class clsEmail
    {
        public clsEmail() {
	}

    private int id;

    private clsPessoa pessoa;

    private string email;

    public int Id { get => id; set => id = value; }
    public clsPessoa Pessoa { get => pessoa; set => pessoa = value; }
    public string Email { get => email; set => email = value; }
    }
}