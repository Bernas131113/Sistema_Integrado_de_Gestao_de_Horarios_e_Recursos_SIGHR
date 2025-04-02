namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    public class Encomenda
    {
        public int Id { get; set; }
        public int UtilizadorId { get; set; }
        public Utilizador ? Utilizador { get; set; }
        public string? Descricao { get; set; }
        public string? Estado { get; set; } // Pendente, Aprovada, Rejeitada
    }
}
