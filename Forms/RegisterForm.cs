using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly MD5CryptoServiceProvider _md5Encrypter = new MD5CryptoServiceProvider();


        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(MainForm mainForm) : this()
        {
            this._mainForm = mainForm;
            _mainForm.ChangeChildTitle("Register");
        }


        private async void RegisterUserBtn_Click(object sender, EventArgs e)
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

            //TODO Hashed password usage

            var _username = textUsername.Text;
            var _pass = textPassword.Text;

            if (await CheckUsernameAvailability(_username))
            {
                using (var _dbContext = new MessengerContext())
                {
                    var _newUser = new User()
                    {
                        Username = _username,
                        Password = _pass
                    };

                    _dbContext.Users.AddOrUpdate(_newUser);
                    await _dbContext.SaveChangesAsync();
                }

                MessageBox.Show($"Well done! {_username.ToUpper()} was registered successfully.", "Success");
                _mainForm.OpenChildForm(new LoginForm(_mainForm));
            }

            // Username is not available
            else
            {
                MessageBox.Show($"Sorry, but {_username} is already taken!", "Invalid Username");
                textUsername.Clear();
                textPassword.Clear();
                textPasswordCheck.Clear();
            }
        }


        /// <summary>
        /// Checks if username is already registered in database.
        /// </summary>
        /// <param name="chosenUsername">Name to be checked.</param>
        /// <returns>True - available, False - not available</returns>
        private async Task<bool> CheckUsernameAvailability(string chosenUsername)
        {
            using (var _dbContext = new MessengerContext())
            {
                var _foundSameUsername = await _dbContext.Users
                    .FirstOrDefaultAsync(x => x.Username == chosenUsername);

                return _foundSameUsername == null;
            }
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new LoginForm(_mainForm));
        }
    }
}
