using System;

namespace SecretSanta.Api.DTO
{
    public class Pairing
    {
        public int Id { get; set; }
        public int SantaId { get; set; }
        public User Santa { get; set; }
        public int RecipientId { get; set; }
        public User Recipient { get; set; }

        public Pairing()
        {
            
        }

        public Pairing(SecretSanta.Api.DTO.Pairing pairing)
        {
            if (pairing == null) throw new ArgumentNullException(nameof(pairing));

            Id = pairing.Id;
            SantaId = pairing.SantaId;
            Santa = pairing.Santa;
            RecipientId = pairing.RecipientId;
            Recipient = pairing.Recipient;
        }
    }
}