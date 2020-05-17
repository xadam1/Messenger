using System.Collections.Generic;

namespace Messenger
{
    public class Conversation
    {
        public int ConversationId { get; set; }
        public User FirstUser { get; set; }
        public User SecondUser { get; set; }
        public IList<Message> Messages { get; set; }
    }
}