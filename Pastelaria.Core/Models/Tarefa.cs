namespace Pastelaria.Core.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int IdTarefaStatus { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataConclusao { get; set; }
        public int IdUsuarioCadastro { get; set; }

        public TarefaStatus TarefaStatus { get; set; }

        public IEnumerable<Comentario> Comentarios { get; set; }
        public IEnumerable<UsuarioTarefa> UsuariosTarefas { get; set; }
    }
}
