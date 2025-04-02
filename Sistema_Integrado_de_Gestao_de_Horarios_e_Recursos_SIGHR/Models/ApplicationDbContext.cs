using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sistema_Integrado_de_Gestao_de_Horarios_e_Recursos_SIGHR.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Encomenda> Encomendas { get; set; }
        public DbSet<Falta> Faltas { get; set; }
    }
}
