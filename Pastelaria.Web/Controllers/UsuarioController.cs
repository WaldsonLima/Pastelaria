using System.Threading.Tasks;
using Pastelaria.Core.Dto;
using Pastelaria.Core.Interfaces;

namespace Pastelaria.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(AppSettings appSettings, IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<IActionResult> Index()
        {
            var usuarios = await _usuarioRepository.BuscarUsuarioAsync(new BuscarUsuarioDto { });
            return View(usuarios);
        }

        public async Task<IActionResult> Cadastrar(Usuario usuario)
        {

            var cadastro = await _usuarioRepository.CadastrarUsuarioAsync(new Usuario
            {
                IdTipoUsuario = usuario.IdTipoUsuario,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                DataExpiracaoSenha = usuario.DataExpiracaoSenha,
                IdUsuarioCadastro = usuario.IdUsuarioCadastro
            });

            return Ok("Usuario cadastrado com sucesso");
        }
    }
}
