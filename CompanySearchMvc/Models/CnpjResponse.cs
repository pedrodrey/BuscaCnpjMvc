﻿using System.ComponentModel.DataAnnotations;

namespace BuscaCnpjMvc.Models
{
    public class CnpjResponse
    {
        public string? Status { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime? UltimaAtualizacao { get; set; }

        [Key]
        [Required(ErrorMessage = "CNPJ é obrigatório")]
        public string Cnpj { get; set; }

        public string? Tipo { get; set; }
        public string? Porte { get; set; }
        public string? Nome { get; set; }
        public string? Fantasia { get; set; }
        public string? Abertura { get; set; }
        public List<AtividadePrincipal>? AtividadePrincipal { get; set; }
        public List<AtividadeSecundaria>? AtividadeSecundaria { get; set; }
        public string? NaturezaJuridica { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }
        public string? Bairro { get; set; }
        public string? Municipio { get; set; }
        public string? Uf { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Efr { get; set; }
        public string? Situacao { get; set; }
        public string? DataSituacao { get; set; }
        public string? MotivoSituacao { get; set; }
        public string? SituacaoEspecial { get; set; }
        public string? DataSituacaoEspecial { get; set; }
        public string? CapitalSocial { get; set; }
        public List<Qsa>? Qsa { get; set; }
        public Simples? Simples { get; set; }
        public Simei? Simei { get; set; }
        public Billing? Billing { get; set; }
    }
}
