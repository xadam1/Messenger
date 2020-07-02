using System.Drawing;
using System.Windows.Forms;
using Messenger.Forms;

namespace Messenger.Controls
{
    public partial class MessageBubble : UserControl
    {
        private readonly string _sender;
        private readonly string _messageText;

        // Ctor
        public MessageBubble()
        {
            InitializeComponent();
        }

        // Ctor with sender name, type of msg and msg itself
        public MessageBubble(User sender, MessageType type, string text) : this()
        {
            _sender = sender.Username;
            _messageText = text;

            // Incoming / Outgoing
            switch (type)
            {
                case MessageType.Incoming:
                    this.BackColor = Color.FromArgb(71,71,71);
                    break;

                case MessageType.Outgoing:
                    this.BackColor = Color.FromArgb(57, 108, 128);
                    break;
            }

            SetMessage();
        }

        // Sets text and sender to UI
        private void SetMessage()
        {
            this.FromUserLbl.Text = _sender;
            this.message.Text = _messageText;
        }
    }
}
