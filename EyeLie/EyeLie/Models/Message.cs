using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeLie.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "The message cannot exceed 250 characters.")]
        public string Content { get; set; }

        public DateTime SentAt { get; set; } = DateTime.Now;

        public string SenderId { get; set; }
        [ForeignKey("SenderId")]
        public User Sender { get; set; }

        public string ReceiverId { get; set; }
        [ForeignKey("ReceiverId")]
        public User Receiver { get; set; }


        public bool IsRead { get; set; } = false;

    }
}
