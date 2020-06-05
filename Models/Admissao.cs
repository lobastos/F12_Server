using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibsServer.Model
{
    public class Admissao
    {
        public DateTime Data { get; set; }
        public String Registro { get; set; }
        [Column(TypeName = "jsonb")]
        public Ferias Ferias { get; set; }

    }
}