using LibsServer.Model.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace LibsServer.Model
{
    public class Endereco
    {
        public DateTime DataCadastro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CodMunicipio { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        
        public string CodPais { get; set; }
        public string Pais { get; set; }
        public string Fone { get; set; }
    }
}
