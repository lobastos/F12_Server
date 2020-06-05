using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using LibsServer.Model.Enum;

namespace LibsServer.Model
{
    public class PessoaFisica : Pessoa
    {
        [Required(ErrorMessage="O CPF é obrigatório", AllowEmptyStrings=false)]
        [MaxLength(11)]
        public string CPF { get; set; }        
        public string RG { get; set; }
        public string RG_LocalExpedicao { get; set; }
        public DateTime RG_DataExpedicao { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Escolaridade { get; set; }
        public string Ocupacao { get; set; }
        public string PaisNatal { get; set; }
        public string EstadoNatal { get; set; }
        public string CidadeNatal { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
    }
}
