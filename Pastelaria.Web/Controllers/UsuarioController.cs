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
    }
}
