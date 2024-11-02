using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace EyeLie.Models
{
    public class User : IdentityUser
    {

        public User()
        {
            Posts = new HashSet<Post>();
        }
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }
        public int ProfileHeartsCount { get; set; }
        public virtual ICollection<Post> Posts { get; set; } 
    }
}
