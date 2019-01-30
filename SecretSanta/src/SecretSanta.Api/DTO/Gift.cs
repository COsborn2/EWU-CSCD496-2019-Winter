using System;

namespace SecretSanta.Api.DTO
{
    public class Gift
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OrderOfImportance { get; set; }
        public string Url { get; set; }

        public Gift(SecretSanta.Domain.Models.Gift gift)
        {
            if (gift == null) throw new ArgumentNullException(nameof(gift));

            Id = gift.Id;
            Title = gift.Title;
            Description = gift.Description;
            OrderOfImportance = gift.OrderOfImportance;
            Url = gift.Url;
        }

        private Gift(){}

        public static SecretSanta.Domain.Models.Gift ToDomain(Gift dtoGift)
        {
           SecretSanta.Domain.Models.Gift modelGift = new Domain.Models.Gift()
           {
               Id = dtoGift.Id,
               Title = dtoGift.Title,
               Description = dtoGift.Description,
               OrderOfImportance = dtoGift.OrderOfImportance,
               Url = dtoGift.Url
           };

           return modelGift;
        }

        public static implicit operator Gift(SecretSanta.Domain.Models.Gift gift)
        {
            if (gift == null) throw new ArgumentNullException(nameof(gift));

            Gift toReturn = new Gift()
            {
                Id = gift.Id,
                Title = gift.Title,
                Description = gift.Description,
                OrderOfImportance = gift.OrderOfImportance,
                Url = gift.Url
            };

            return toReturn;
        }
    }
}
