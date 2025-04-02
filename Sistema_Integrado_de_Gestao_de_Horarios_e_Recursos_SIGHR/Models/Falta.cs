namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    public class Falta
    {
        public int Id { get; set; }
        public int UtilizadorId { get; set; }
        public Utilizador ? Utilizador { get; set; }
        public DateTime Data { get; set; }
        public string? Motivo { get; set; }
    }
}
