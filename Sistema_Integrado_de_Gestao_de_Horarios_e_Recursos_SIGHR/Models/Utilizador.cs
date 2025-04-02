namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? PIN { get; set; }
        public string? Tipo { get; set; } // Administrador, Funcionário de Escritório, Colaborador
    }
}
