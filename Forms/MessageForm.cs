using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Controls;

namespace Messenger.Forms
{
    public partial class MessageForm : Form
    {
        private readonly User _activeUser;
        private readonly User _receiver;
        private Conversation _conversation;


        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(User activeUser, User receiver) : this()
        {
            _activeUser = activeUser;
            _receiver = receiver;

            Initialize();
        }

        private async Task Initialize()
        {
            await LoadConversation();
            DisplaySentMessages();
        }


        private async Task LoadConversation()
        {
            using (var _db = new MessengerContext())
            {
                // Attaching users to this context
                _db.Users.Attach(_activeUser);
                _db.Users.Attach(_receiver);

                // Find conversation between these two users if one already exists
                var _conversationsMatch = await _db.Conversations
                    .Where(c => c.FirstUser.UserId == _activeUser.UserId || c.FirstUser.UserId == _receiver.UserId)
                    .Where(c => c.SecondUser.UserId == _activeUser.UserId || c.SecondUser.UserId == _receiver.UserId)
                    .Include(x => x.Messages)
                    .SingleOrDefaultAsync();

                if (_conversationsMatch != null)
                {
                    _conversation = _conversationsMatch;
                }

                else
                {   // Only runs when Conversation does not exists
                    var _newConversation = new Conversation
                    {
                        FirstUser = _activeUser,
                        SecondUser = _receiver,
                        Messages = new List<Message>()
                    };

                    _conversation = _newConversation;

                    _db.Conversations.AddOrUpdate(_newConversation);
                    await _db.SaveChangesAsync();
                }
            }
        }


        private void DisplaySentMessages()
        {
            if (_conversation.Messages.Count < 1)
            {
                Console.WriteLine("DEBUG: No messages found.");
                return;
            }

            foreach (var _message in _conversation.Messages)
            {
                // Decide whether is the message incoming or outgoing
                var _msgType = _message.Sender.UserId == _activeUser.UserId ? MessageType.Outgoing : MessageType.Incoming;

                var _messageBubble = new MessageBubble(_message.Sender, _msgType, _message.Text);
                messageFlowLayoutPanel.Controls.Add(_messageBubble);
            }
        }


        private async void SendButton_Click(object sender, EventArgs e)
        {
            var _messageBubble = new MessageBubble(_activeUser, MessageType.Outgoing, messageTextBox.Text);
            messageFlowLayoutPanel.Controls.Add(_messageBubble);

            using (var _db = new MessengerContext())
            {
                _db.Users.Attach(_activeUser);
                _db.Conversations.Attach(_conversation);

                var _message = new Message()
                {
                    Sender = _activeUser,
                    Text = messageTextBox.Text
                };

                _conversation.Messages.Add(_message);

                // Assign updated Message list to object in db
                var _dbMessages = await _db.Conversations.FirstAsync(x => x.ConversationId == _conversation.ConversationId);
                _dbMessages.Messages = _conversation.Messages;

                await _db.SaveChangesAsync();
                messageTextBox.Clear();
            }
        }
    }
}
