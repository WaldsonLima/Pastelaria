namespace Pastelaria.Core.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public int IdTarefa { get; set; }
        public int IdComentarioRespondido { get; set; }
        public string Comentarioo { get; set; }
        public int IdUsuarioCadastro { get; set; }

        public Tarefa Tarefa { get; set; }
        public Comentario idComentario { get; set; }
        public IEnumerable<Comentario> Comentarios { get; set; }
    }
}
