namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}