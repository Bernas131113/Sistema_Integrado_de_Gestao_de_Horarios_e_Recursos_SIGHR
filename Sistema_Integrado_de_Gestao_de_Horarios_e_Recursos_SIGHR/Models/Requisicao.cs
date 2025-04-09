namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Requisicao
    {
        [Key, Column(Order = 0)]
        public long MaterialId { get; set; }

        [Key, Column(Order = 1)]
        public long EncomendaId { get; set; }

        [Required]
        public long Quantidade { get; set; }

        [ForeignKey("MaterialId")]
        public Material Material { get; set; }

        [ForeignKey("EncomendaId")]
        public Encomenda Encomenda { get; set; }
    }
}
