using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public class Comment
    {
        public Comment() { }

        public Comment(string text) : this()
        {
            Text = text;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Text { get; set; } = string.Empty;     

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; 

        // Foreign keys
        public int TaskItemId { get; set; }
        public int UserId { get; set; }

        // Navigation properties (EF will populate these)
        public TaskItem TaskItem { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
