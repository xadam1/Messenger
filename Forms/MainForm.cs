using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;


namespace Messenger
{
    public partial class MainForm : Form
    {
        private Form _activeForm;
        private User _activeUser;
        private List<string> _allUsers;


        public MainForm()
        {
            InitializeComponent();

            LoadUsers();
        }


        #region Form buttons handlers

        private void BtnUser_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new LoginForm(this));
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm(null);
        }


        private void sendNewMessageButton_Click(object sender, EventArgs e)
        {
            if (_activeUser == null)
            {
                MessageBox.Show("You need to log in first!", "LogIn");
                SwitchNewMessageOverlay();
                return;
            }

            var _receiverName = comboBox1.SelectedItem as string;

            using (var _db = new MessengerContext())
            {
                var _receiver = _db.Users
                    .Where(x => x.Username.Equals(_receiverName))
                    .Select(x => x as User)
                    .FirstOrDefault();

                var _messageToUser = new MessageToUser(this, _receiver, _activeUser);
                this.flowlayoutMessages.Controls.Add(_messageToUser);
            }

            SwitchNewMessageOverlay();
        }


        private void newMessageOverlayBtn_Click(object sender, EventArgs e)
        {
            SwitchNewMessageOverlay();
        }

        #endregion


        #region Private methods

        private void LoadUsers()
        {
            using (var _db = new MessengerContext())
            {
                _allUsers = _db.Users
                    .Select(x => x.Username)
                    .ToList();
            }

            comboBox1.DataSource = _allUsers;
        }


        private void SwitchNewMessageOverlay()
        {
            if (newMessagePanelToggle.Visible)
            {
                this.newMessagePanelToggle.Visible = false;
                this.addMessageOverlayPanel.Visible = true;
            }
            else
            {
                this.addMessageOverlayPanel.Visible = false;
                this.newMessagePanelToggle.Visible = true;
            }

        }

        #endregion


        #region Public methods

        /// <summary>
        /// Opens child form in Child-form-panel and sets it properly.
        /// </summary>
        /// <param name="childForm">New Child Form/Control that will be shown.</param>
        public void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelSubForm.Controls.Add(childForm);
            this.panelSubForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        /// <summary>
        /// Sets _activeUser field to new User and changes name in side panel.
        /// </summary>
        /// <param name="newUser">New User</param>
        public void UserChanged(User newUser)
        {
            _activeUser = newUser;

            this.btnUser.Text = newUser.Username;
            ChangeChildTitle($"Welcome {newUser.Username}");

            // Remove all messages
            this.flowlayoutMessages.Controls.Clear();

            using (var _dbContext = new MessengerContext())
            {
                _dbContext.Users.Attach(_activeUser);

                // Add users who have conversation with currently logged user
                var _receivers = _dbContext.Conversations
                    .Where(x => x.FirstUser.UserId == _activeUser.UserId)
                    .Select(x => x.SecondUser)
                    .ToList();

                _receivers.AddRange(_dbContext.Conversations
                    .Where(x => x.SecondUser.UserId == _activeUser.UserId)
                    .Select(x => x.FirstUser)
                    .ToList());

                foreach (var _receiver in _receivers)
                {
                    var _messageToUser = new MessageToUser(this, _receiver, _activeUser);
                    this.flowlayoutMessages.Controls.Add(_messageToUser);
                }
            }
        }


        /// <summary>
        /// Changes title of the child title.
        /// </summary>
        /// <param name="newTitle">New title to be written.</param>
        /// <returns>True, if 'newTitle' was set as new title.</returns>
        public bool ChangeChildTitle(string newTitle)
        {
            if (newTitle == null || newTitle.Equals(String.Empty))
            {
                lblTitle.Text = "HOME";
                return false;
            }

            lblTitle.Text = newTitle;
            var newTitleX = titlePanel.Size.Width / 2 - (2 * newTitle.Length);
            lblTitle.Location = new Point(newTitleX, lblTitle.Location.Y);
            return true;
        }


        /// <summary>
        /// Closes child form/control, and resets title.
        /// </summary>
        /// <param name="newTitle">New title to be displayed, 'HOME' default</param>
        public void CloseChildForm(string newTitle = null)
        {
            if (_activeForm == null) return;

            _activeForm.Close();
            _activeForm = null;
            ChangeChildTitle(newTitle);
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            this.newMessagePanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.newMessagePanel.Visible = true;

        }

    }
}
