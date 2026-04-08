using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public class Project
    {
        public Project()
        {
            Tasks = new List<TaskItem>();
        }

        public Project(string name, string description) : this()
        {
            Name = name;
            Description = description;
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;        // init

        [StringLength(500)]
        public string Description { get; set; } = string.Empty; // init

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        // Foreign key
        public int UserId { get; set; }

        // Navigation properties
        public User User { get; set; } = null!;                 // EF sets
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
