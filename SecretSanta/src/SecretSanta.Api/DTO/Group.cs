using System;
using System.Collections.Generic;

namespace SecretSanta.Api.DTO
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SecretSanta.Api.DTO.GroupUser> GroupUsers { get; set; }

        public Group()
        {
                
        }

        public Group(SecretSanta.Api.DTO.Group group)
        {
            if (group == null) throw new ArgumentNullException(nameof(group));

            Id = group.Id;
            Name = group.Name;
            GroupUsers = group.GroupUsers;
        }
    }
}
