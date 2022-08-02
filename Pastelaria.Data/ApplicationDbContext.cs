using Pastelaria.Core.Models;

namespace Pastelaria.Data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext (AppSettings appSettings) : base(appSettings, "Application")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<UsuarioTarefa> UsuariosTarefas { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<TarefaStatus> TarefaStatus { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}
