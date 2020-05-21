using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Messenger.Forms
{
    public partial class RegisterForm : Form
    {
        private MainForm _mainForm;
        private MD5CryptoServiceProvider md5Encrypter = new MD5CryptoServiceProvider();


        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(MainForm mainForm) : this()
        {
            this._mainForm = mainForm;
            _mainForm.ChangeChildTitle("Register");
        }


        private void registerUserBtn_Click(object sender, EventArgs e)
        {
            // Check if input is not empty
            if (textUsername.Text == String.Empty || textPassword.Text == String.Empty)
            {
                MessageBox.Show("Invalid username or password.\n\nPlease try again with valid inputs.", "Invalid Arguments");
                textUsername.Clear();
                textPassword.Clear();
                textPasswordCheck.Clear();
                return;
            }

            // Check if retyped password is correct
            if (textPassword.Text != textPasswordCheck.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error");
                textPassword.Clear();
                textPasswordCheck.Clear();
                return;
            }

            var _username = textUsername.Text;
            var _pass = textPassword.Text;

            if (CheckUsernameAvailability(_username))
            {
                using (var _dbContext = new MessengerContext())
                {
                    var _newUser = new User()
                    {
                        Username = _username,
                        Password = _pass
                    };

                    _dbContext.Users.AddOrUpdate(_newUser);
                    _dbContext.SaveChanges();
                }

                MessageBox.Show($"Well done! {_username.ToUpper()} was registered successfully.", "Success");
                _mainForm.OpenChildForm(new LoginForm(_mainForm));
            }

            else
            {
                MessageBox.Show($"Sorry, but {_username} is already taken!", "Invalid Username");
                textUsername.Clear();
                textPassword.Clear();
                textPasswordCheck.Clear();
            }
        }

        // Checks if username is already registered in database
        // True - available, False - not available
        private bool CheckUsernameAvailability(string chosenUsername)
        {
            using (var _dbContext = new MessengerContext())
            {
                var _foundSameUsername = _dbContext.Users
                    .FirstOrDefault(x => x.Username == chosenUsername);

                return _foundSameUsername == null;
            }
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new LoginForm(_mainForm));
        }
    }
}
