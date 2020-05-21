using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Controls;

namespace Messenger
{
    public partial class MessageForm : Form
    {
        private MainForm _mainForm;
        private User _activeUser;
        private User _receiver;
        private Conversation _conversation = null;


        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(MainForm mainForm, User activeUser, User receiver) : this()
        {
            _mainForm = mainForm;
            _activeUser = activeUser;
            _receiver = receiver;

            LoadConversation();
            DisplaySentMessages();
        }


        private void LoadConversation()
        {
            using (var _db = new MessengerContext())
            {
                // Attaching users to this context
                _db.Users.Attach(_activeUser);
                _db.Users.Attach(_receiver);

                // Find conversation between these two users if one already exists
                /*
                var _conversationsMatch = _db.Conversations
                    .Include(x => x.Messages)
                    .Include(x => x.FirstUser)
                    .Include(x => x.SecondUser)
                    .FirstOrDefault(conv =>
                        (conv.FirstUser.UserId == _activeUser.UserId || conv.FirstUser.UserId == _receiver.UserId) &&
                        conv.SecondUser.UserId == _activeUser.UserId || conv.SecondUser.UserId == _receiver.UserId);
                */
                
                var _conversationsMatch = _db.Conversations
                    .Where(c => c.FirstUser.UserId == _activeUser.UserId || c.FirstUser.UserId == _receiver.UserId)
                    .Where(c => c.SecondUser.UserId == _activeUser.UserId || c.SecondUser.UserId == _receiver.UserId)
                    .Include(x => x.Messages)
                    .SingleOrDefault();
                
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
                    _db.SaveChanges();
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
                // TODO add enum representing Incoming/Outgoing messages -> change color of bubble
                var _messageBubble = new MessageBubble(_mainForm, _message.Sender, _message.Text);
                messageFlowLayoutPanel.Controls.Add(_messageBubble);
            }
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            var _messageBubble = new MessageBubble(_mainForm, _activeUser, messageTextBox.Text);
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
                _db.Conversations.First(x => x.ConversationId == _conversation.ConversationId).Messages =
                    _conversation.Messages;

                _db.SaveChanges();
                messageTextBox.Clear();
            }
        }
    }
}
