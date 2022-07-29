namespace Pastelaria.Core.Models
{
    public class TarefaStatus
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<Tarefa> Tarefas { get; set; }
    }
}
