using Pastelaria.Core.Models;

namespace Pastelaria.Data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext (AppSettings appSettings) : base(appSettings, "Aplication")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<UsuarioTarefa> UsuarioTarefas { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<TarefaStatus> TarefaStatus { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}
