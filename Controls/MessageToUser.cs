using System;
using System.Windows.Forms;
using Messenger.Forms;

namespace Messenger.Controls
{
    public partial class MessageToUser : UserControl
    {
        public static MainForm _mainForm;
        private readonly User _receiver;
        private readonly User _activeUser;

        public MessageToUser()
        {
            InitializeComponent();
        }

        public MessageToUser(MainForm mainFormReference, User receiver, User activeUser) : this()
        {
            _mainForm = mainFormReference;
            _receiver = receiver;
            _activeUser = activeUser;

            this.Receiver.Text = receiver.Username;
        }

        public bool CheckUserSimilarityAndClick(User user)
        {
            if (user.UserId != _receiver.UserId) return false;
            
            Username_Click(null, EventArgs.Empty);
            return true;
        }

        private void Username_Click(object sender, EventArgs e)
        {
            _mainForm.ChangeChildTitle($"{_receiver.Username.ToUpper()} CHAT");
            _mainForm.OpenChildForm(new MessageForm(_mainForm, _activeUser, _receiver));
        }
    }
}
