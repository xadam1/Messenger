namespace Messenger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedConversationsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conversations",
                c => new
                    {
                        ConversationId = c.Int(nullable: false, identity: true),
                        FirstUser_UserId = c.Int(),
                        SecondUser_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ConversationId)
                .ForeignKey("dbo.Users", t => t.FirstUser_UserId)
                .ForeignKey("dbo.Users", t => t.SecondUser_UserId)
                .Index(t => t.FirstUser_UserId)
                .Index(t => t.SecondUser_UserId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Sender_UserId = c.Int(),
                        Conversation_ConversationId = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Users", t => t.Sender_UserId)
                .ForeignKey("dbo.Conversations", t => t.Conversation_ConversationId)
                .Index(t => t.Sender_UserId)
                .Index(t => t.Conversation_ConversationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conversations", "SecondUser_UserId", "dbo.Users");
            DropForeignKey("dbo.Messages", "Conversation_ConversationId", "dbo.Conversations");
            DropForeignKey("dbo.Messages", "Sender_UserId", "dbo.Users");
            DropForeignKey("dbo.Conversations", "FirstUser_UserId", "dbo.Users");
            DropIndex("dbo.Messages", new[] { "Conversation_ConversationId" });
            DropIndex("dbo.Messages", new[] { "Sender_UserId" });
            DropIndex("dbo.Conversations", new[] { "SecondUser_UserId" });
            DropIndex("dbo.Conversations", new[] { "FirstUser_UserId" });
            DropTable("dbo.Messages");
            DropTable("dbo.Conversations");
        }
    }
}
