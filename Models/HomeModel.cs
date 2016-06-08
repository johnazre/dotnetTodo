using System;

namespace aspTodoApp.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean completed { get; set; }
    }
}