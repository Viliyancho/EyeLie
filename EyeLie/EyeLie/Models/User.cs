using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace EyeLie.Models
{
    public class User : IdentityUser
    {


        public User()
        {
            Posts = new HashSet<Post>();
            SentMessages = new List<Message>();
            ReceivedMessages = new List<Message>();
        }
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }
        public int ProfileHeartsCount { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
    }
}
