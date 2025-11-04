namespace MyTodos.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime DouDate { get; set; }
        public virtual Person? Person { get; set; }
        public int PersonId { get; set; }
    }
}
