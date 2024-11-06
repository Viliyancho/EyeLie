using System.ComponentModel.DataAnnotations;

namespace EyeLie.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "The comment cannot exceed 150 characters.")]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public virtual User UserUser { get; set; }

        public int PostId { get; set; }

        public virtual Post PostPost { get; set; }
    }
}
