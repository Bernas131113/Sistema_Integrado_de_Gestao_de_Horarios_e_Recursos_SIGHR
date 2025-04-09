namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Material
    {
        public long Id { get; set; }

        [Required]
        public string Descricao { get; set; }

        public ICollection<Requisicao> Requisicoes { get; set; }
    }
}
