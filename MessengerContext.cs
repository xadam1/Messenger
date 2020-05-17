using System.Data.Entity;

namespace Messenger
{
    public class MessengerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        

        public MessengerContext()
            : base("name=DefaultConnection")
        {
        }
    }
}