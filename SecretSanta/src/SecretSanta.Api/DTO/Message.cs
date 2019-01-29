using System;

namespace SecretSanta.Api.DTO
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public User Sender { get; set; }
        public int RecipientId { get; set; }
        public User Recipient { get; set; }
        public string ChatMessage { get; set; }

        public Message()
        {
            
        }

        public Message(SecretSanta.Api.DTO.Message message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            Id = message.Id;
            SenderId = message.SenderId;
            Sender = message.Sender;
            RecipientId = message.RecipientId;
            Recipient = message.Recipient;
            ChatMessage = message.ChatMessage;
        }
    }
}