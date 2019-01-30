﻿using System;

namespace SecretSanta.Api.DTO
{
    public class Gift
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OrderOfImportance { get; set; }
        public string Url { get; set; }

        public Gift()
        {
                
        }

        public Gift(SecretSanta.Domain.Models.Gift gift)
        {
            if (gift == null) throw new ArgumentNullException(nameof(gift));

            Id = gift.Id;
            Title = gift.Title;
            Description = gift.Description;
            OrderOfImportance = gift.OrderOfImportance;
            Url = gift.Url;
        }

        public static SecretSanta.Domain.Models.Gift ToEntity(DTO.Gift gift)
        {
            if (gift == null) throw new ArgumentNullException(nameof(gift));
            
            return new Domain.Models.Gift()
            {
                Id = gift.Id,
                Title = gift.Title,
                Description = gift.Description,
                OrderOfImportance = gift.OrderOfImportance,
                Url = gift.Url
            };
        }
    }
}
