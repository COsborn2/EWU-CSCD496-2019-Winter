using System;

namespace SecretSanta.Api.DTO
{
    public class GroupUser
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public GroupUser()
        {
            
        }

        public GroupUser(SecretSanta.Api.DTO.GroupUser groupUser)
        {
            if (groupUser == null) throw new ArgumentNullException(nameof(groupUser));

            GroupId = groupUser.GroupId;
            Group = groupUser.Group;
            UserId = groupUser.UserId;
            User = groupUser.User;
        }
    }
}