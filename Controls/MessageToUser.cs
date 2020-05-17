﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class MessageToUser : UserControl
    {
        public static MainForm _mainForm;
        private User _receiver;
        private User _activeUser;

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
