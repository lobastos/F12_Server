using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibsServer.Model
{
    public class Usuario : Pessoa
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public Funcionario Funcionario {get; set;}
    }
}
