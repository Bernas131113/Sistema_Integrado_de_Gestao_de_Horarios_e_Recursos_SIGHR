﻿namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Encomenda
    {
        public long Id { get; set; }

        [Required]
        public long UtilizadorId { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public bool EstadoAtual { get; set; }

        [ForeignKey("UtilizadorId")]
        public Utilizador Utilizador { get; set; }

        public ICollection<Requisicao> Requisicoes { get; set; }
    }
}
