using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibsServer.Model
{
    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
        public string CTPS { get; set; }
        public string NIS { get; set; }
        [Column(TypeName = "jsonb")]
        public Admissao Admissao { get; set; }
    }
}
