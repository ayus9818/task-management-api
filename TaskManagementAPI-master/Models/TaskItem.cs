using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public class TaskItem
    {
        public TaskItem()
        {
            Comments = new List<Comment>();
        }

        public TaskItem(string title, string description) : this()
        {
            Title = title;
            Description = description;
        }

        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; } = string.Empty;        // init

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;  // init

        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public DateTime? DueDate { get; set; }                   // make optional

        // Foreign keys
        public int ProjectId { get; set; }
        public int? AssignedUserId { get; set; }

        // Navigation properties
        public Project Project { get; set; } = null!;            // EF sets
        public User? AssignedUser { get; set; }                  // optional
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }
}
