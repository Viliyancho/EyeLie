using EyeLie.Models;

namespace EyeLie.ViewModels
{
    public class ProfileViewModel
    {

        public User User { get; set; } // Потребителят, чийто профил се разглежда

        // Булево свойство за проверка дали текущият потребител е собственик на профила
        public bool IsOwner { get; set; }

        public ProfileViewModel(User user, string currentUserId)
        {
            User = user;
            IsOwner = user.Id == currentUserId;
        }
    }
}