namespace EyeLie.Models
{
    public class Post 
    {
        public int Id { get; set; } 

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public virtual User UserUser { get; set; }
    }
}