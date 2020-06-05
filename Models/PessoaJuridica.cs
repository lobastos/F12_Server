using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibsServer.Model
{
    public class PessoaJuridica : Pessoa
    {
        [Required(ErrorMessage="O CNPJ é obrigatório",AllowEmptyStrings=false)]
        [MaxLength(14)]
        public int CNPJ { get; set; }        
        public string Fantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        
    }
}
