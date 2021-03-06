﻿using System;
using System.Windows.Forms;
using Messenger.Forms;

namespace Messenger.Controls
{
    public partial class MessageToUser : UserControl
    {
        public static MainForm _mainForm;
        private readonly User _receiver;
        private readonly User _activeUser;

        // Ctor
        public MessageToUser()
        {
            InitializeComponent();
        }

        // Ctor sets MainForm, receiver and logged in user - represents conversation
        public MessageToUser(MainForm mainFormReference, User receiver, User activeUser) : this()
        {
            _mainForm = mainFormReference;
            _receiver = receiver;
            _activeUser = activeUser;

            this.Receiver.Text = receiver.Username;
        }

        /// <summary>
        /// Checks for user(name) similarity. If the user is _receiver, clicks.
        /// </summary>
        /// <param name="user">User to be checked with receiver of this current conversation.</param>
        /// <returns>False if user is not "target", clicks otherwise.</returns>
        public bool CheckUserSimilarityAndClick(User user)
        {
            if (user.UserId != _receiver.UserId) return false;

            Username_Click(null, EventArgs.Empty);
            return true;
        }

        /// <summary>
        /// Opens conversation with receiver
        /// </summary>
        public void OpenConversation()
        {
            this.Username_Click(this, EventArgs.Empty);
        }

        // Basically simulates clicking on receiver username
        private void Username_Click(object sender, EventArgs e)
        {
            _mainForm.ChangeChildTitle($"{_receiver.Username.ToUpper()} CHAT");
            _mainForm.OpenChildForm(new MessageForm(_activeUser, _receiver));
        }
    }
}
