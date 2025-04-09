namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Utilizador
    {
        public long Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public int PIN { get; set; }

        [Required]
        public string Tipo { get; set; }

        public ICollection<Horario> Horarios { get; set; }
        public ICollection<Falta> Falta { get; set; }
        public ICollection<Encomenda> Encomendas { get; set; }
    }
}
