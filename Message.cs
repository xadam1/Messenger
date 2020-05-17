namespace Messenger
{
    public class Message
    {
        public int MessageId { get; set; }
        public User Sender { get; set; }
        public string Text { get; set; }
    }
}