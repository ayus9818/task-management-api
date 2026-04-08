using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public class User
    {
        public User()
        {
            Projects = new List<Project>();
            AssignedTasks = new List<TaskItem>();
            Comments = new List<Comment>();
        }

        public User(string username, string email, string passwordHash) : this()
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }

        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; } = string.Empty;   // init

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;      // init

        [Required]
        public string PasswordHash { get; set; } = string.Empty; // init

        // Navigation properties
        public ICollection<Project> Projects { get; set; } = new List<Project>();
        public ICollection<TaskItem> AssignedTasks { get; set; } = new List<TaskItem>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
