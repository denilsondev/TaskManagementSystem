using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Domain.Entities
{
    public class Task
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public bool IsCompleted { get; private set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Task(string title, string? description)
        {
            Title = title;
            Description = description;
            IsCompleted = false;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now; 
        }

        public void Update(string title, string? description, bool isCompleted)
        {
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
