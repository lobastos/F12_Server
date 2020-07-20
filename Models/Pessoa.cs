using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using LibsServer.Model.Enum;


namespace LibsServer.Model
{
    public abstract class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DataCadastro { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
        [Required(ErrorMessage="O nome é obrigatório",AllowEmptyStrings=false)]
        public string Nome { get; set; }
        [Required(ErrorMessage="O e-mail é obrigatório",AllowEmptyStrings=false)]
        public string Email { get; set; }
        [Required(ErrorMessage="O telefone é obrigatório",AllowEmptyStrings=false)]
        public string Telefone { get; set; }
        [Column(TypeName = "jsonb")]
        public Endereco Endereco { get; set; }
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataNascimento { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string Observacoes { get; set; }
        [Column(TypeName = "jsonb")]
        public DadosBancarios dadosBancarios {get; set;}
    }
}
