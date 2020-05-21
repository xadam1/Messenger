using System.Windows.Forms;
using Messenger.Forms;

namespace Messenger.Controls
{
    public partial class MessageBubble : UserControl
    {
        private MainForm _mainForm;
        private string _sender;
        private string _messageText;


        public MessageBubble()
        {
            InitializeComponent();
        }


        public MessageBubble(MainForm mainForm, User sender, string text) : this()
        {
            _mainForm = mainForm;
            _sender = sender.Username;
            _messageText = text;

            SetMessage();
        }

        
        private void SetMessage()
        {
            this.FromUserLbl.Text = _sender;
            this.message.Text = _messageText;
        }
    }
}
