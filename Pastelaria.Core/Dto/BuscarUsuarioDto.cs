namespace Pastelaria.Core.Dto
{
    public class BuscarUsuarioDto
    {
        public int Id { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataExpiracaoSenha { get; set; }
    }
}
