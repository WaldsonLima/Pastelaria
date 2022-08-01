namespace Pastelaria.Data.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        
        public UsuarioRepository (ApplicationDbContext dbContext) : base(dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public async Task<IEnumerable<Usuario>> BuscarUsuarioAsync(Usuario usuario)
        {
            var query = _applicationDbContext.Usuarios
                .AsSingleQuery()
                .AsQueryable();

            return await query.Select(x => new Usuario
                {
                    Id = x.Id,
                    IdTipoUsuario = x.IdTipoUsuario,
                    Nome = x.Nome,
                    Email = x.Email,
                    DataExpiracaoSenha = x.DataExpiracaoSenha
                })
                .ToListAsync();
        }

        public async Task CadastrarUsuarioAsync(Usuario usuario)
        {
            await _applicationDbContext.Usuarios.AddAsync(usuario);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task EditarUsuarioAsync(int id, object camposEditados)
        {
            await _applicationDbContext.UpdateEntryAsync<Usuario>(id, camposEditados);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
