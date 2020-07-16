using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Controls;

namespace Messenger.Forms
{
    public partial class MainForm : Form
    {
        private Form _activeForm;
        private User _activeUser;
        private List<string> _allUsers;
        private readonly List<User> _openConversations = new List<User>();

        // Ctor
        public MainForm()
        {
            InitializeComponent();

            // This just 'unlags' the database for the first time, because EF is building the model
            // when interacting with the database for the first time
            DatabaseUnlag();
        }


        #region Button clicks handlers

        // Handles the click event on 'btnUser'
        private void BtnUser_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new LoginForm(this));
        }

        // Handles the click event on 'exitBtn'
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            CloseChildForm(null);
        }

        // Handles the click event on 'sendNewMessageButton'
        private async void SendNewMessageButton_Click(object sender, EventArgs e)
        {
            // Check if user is logged in 
            if (_activeUser == null)
            {
                MessageBox.Show("You need to log in first!", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SwitchNewMessageOverlay();
                return;
            }

            var _receiverName = receiverComboBox.SelectedItem as string;

            using (var _db = new MessengerContext())
            {
                // Get user from DB as <User>
                var _receiver = await _db.Users
                    .FirstOrDefaultAsync(x => x.Username.Equals(_receiverName));

                // Check for invalid receiver
                if (_receiver == null || _receiver.UserId == _activeUser.UserId)
                {
                    Console.WriteLine("DEBUG: Tried to add MessageToUser to same user as currently logged, or receiver was null.");
                    return;
                }

                // Check for already open conversations
                if (_openConversations.SingleOrDefault(x => x.UserId == _receiver.UserId) != null)
                {
                    foreach (Control _messagesControl in this.flowlayoutMessages.Controls)
                    {
                        var _msg = _messagesControl as MessageToUser;
                        if (_msg.CheckUserSimilarityAndClick(_receiver)) { return; }
                    }
                }

                // Conversation with new user
                var _messageToUser = new MessageToUser(this, _receiver, _activeUser);
                this.flowlayoutMessages.Controls.Add(_messageToUser);
                _openConversations.Add(_receiver);
                _messageToUser.OpenConversation();
            }

            SwitchNewMessageOverlay();
        }

        // Handles the click event on 'newMessageOverlayBtn'
        private void NewMessageOverlayBtn_Click(object sender, EventArgs e)
        {
            SwitchNewMessageOverlay();
        }

        #endregion


        #region Private methods

        /// <summary>
        /// Creates 'MessageToUser' for every user which has currently conversation with currently logged in user '_activeUser'.
        /// </summary>
        /// <returns>Void</returns>
        private async Task LoadConversations()
        {
            using (var _dbContext = new MessengerContext())
            {
                _dbContext.Users.Attach(_activeUser);

                // Add users who have conversation with currently logged user
                var _receivers = await _dbContext.Conversations
                    .Where(x => x.FirstUser.UserId == _activeUser.UserId)
                    .Select(x => x.SecondUser)
                    .ToListAsync();

                _receivers.AddRange(await _dbContext.Conversations
                    .Where(x => x.SecondUser.UserId == _activeUser.UserId)
                    .Select(x => x.FirstUser)
                    .ToListAsync());

                // Create 'MessageToUser' for every receiver
                foreach (var _receiver in _receivers)
                {
                    var _messageToUser = new MessageToUser(this, _receiver, _activeUser);
                    this.flowlayoutMessages.Controls.Add(_messageToUser);
                    _openConversations.Add(_receiver);
                }
            }
        }

        /// <summary>
        /// Loads every user except currently logged in user ('_activeUser') into the receiver combo box.
        /// </summary>
        /// <returns>Void</returns>
        private async Task LoadUsers()
        {
            using (var _db = new MessengerContext())
            {
                // Select all users except '_activeUser'
                _allUsers = await _db.Users
                    .Where(u => u.UserId != _activeUser.UserId)
                    .Select(u => u.Username)
                    .ToListAsync();
            }

            receiverComboBox.DataSource = _allUsers;
        }

        /// <summary>
        /// Controls whether the receiver combobox or text with '+' btn is visible and switches between them.
        /// </summary>
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

        /// <summary>
        /// Basically "debug" function. Just connects to the DB and select user with ID == 1.
        /// </summary>
        private async Task DatabaseUnlag()
        {
            using (var _db = new MessengerContext())
            {
                var _lagUser = await Task.Run(() => _db.Users.FirstAsync());
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
            // if there is child form, close it first
            _activeForm?.Close();

            // set new child form from param
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
        /// Sets _activeUser field to 'newUser' and changes name in side panel.
        /// </summary>
        /// <param name="newUser">New User</param>
        public async Task UserChanged(User newUser)
        {
            _openConversations.Clear();

            _activeUser = newUser;

            this.btnUser.Text = newUser.Username;
            ChangeChildTitle($"Welcome {newUser.Username}");

            // Clear all "conversation" buttons
            this.flowlayoutMessages.Controls.Clear();

            // Update open conversations
            await LoadConversations();

            // New message receiver update
            await LoadUsers();
        }


        /// <summary>
        /// Changes the text of child - it's title.
        /// </summary>
        /// <param name="newTitle">New title to be set.</param>
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

    }
}
