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


        private void Username_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new MessageForm(_mainForm, _activeUser, _receiver));
        }
    }
}
