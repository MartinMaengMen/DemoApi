using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Domain.DTO
{
    public class UserDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int? TeamId { get; set; }
        public User DTOtoEntity()
        {
            User user = new User();
            user.Username = Username;
            user.Password = Password;
            if(TeamId!=null)
                user.Team.Id = TeamId.Value;
            return user;
        }
    }
}
