namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public int UtilizadorId { get; set; }
        public Utilizador? Utilizador { get; set; } 
        public DateTime Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public DateTime? Intervalo { get; set; }
    }

}
