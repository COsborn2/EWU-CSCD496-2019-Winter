using System;
using System.Collections.Generic;

namespace SecretSanta.Api.DTO
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Gift> Gifts { get; set; }
        public List<GroupUser> GroupUsers { get; set; }

        public User()
        {
            
        }

        public User(SecretSanta.Api.DTO.User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Gifts = user.Gifts;
            GroupUsers = user.GroupUsers;
        }
    }
}