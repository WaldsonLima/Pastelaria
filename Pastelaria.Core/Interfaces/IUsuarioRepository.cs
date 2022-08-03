using Pastelaria.Core.Dto;

namespace Pastelaria.Core.Interfaces
{
	public interface IUsuarioRepository
	{
		 Task<IEnumerable<Usuario>> BuscarUsuarioAsync(BuscarUsuarioDto dto);
		 Task CadastrarUsuarioAsync(Usuario usuario);
	}
}
