using System.Drawing;
using System.Windows.Forms;
using Messenger.Forms;

namespace Messenger.Controls
{
    public partial class MessageBubble : UserControl
    {
        private readonly string _sender;
        private readonly string _messageText;


        public MessageBubble()
        {
            InitializeComponent();
        }


        public MessageBubble(User sender, MessageType type, string text) : this()
        {
            _sender = sender.Username;
            _messageText = text;

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


        private void SetMessage()
        {
            this.FromUserLbl.Text = _sender;
            this.message.Text = _messageText;
        }
    }
}
