using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger.Forms
{
    public partial class LoginForm : Form
    {
        private readonly MainForm _mainForm;
        private readonly MD5CryptoServiceProvider _md5Crypto = new MD5CryptoServiceProvider();

        // Ctor
        public LoginForm()
        {
            InitializeComponent();
        }

        // Overloaded ctor, sets reference for the MainForm, to access it's methods
        public LoginForm(MainForm mainForm) : this()
        {
            this._mainForm = mainForm;
            _mainForm.ChangeChildTitle("Log In");
        }

        #region Button clicks handlers

        // Handles the click event on 'loginBtn'
        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string _username = textUsername.Text;
            string _pass = textPassword.Text;

            // Compute hashed pass
            var _hashedPass = Encoding.ASCII.GetString(_md5Crypto.ComputeHash(Encoding.ASCII.GetBytes(_pass)));

            Console.WriteLine($"DEBUG:\nUsername={_username}\nPassword={_pass}\nHashedPass={_hashedPass}");

            // Try to log in user
            var _newUser = await LoginUser(_username, _hashedPass);

            // User not found
            if (_newUser == null)
            {
                MessageBox.Show("Username or Password is incorrect!\n\n" +
                                "If you don't have account yet, please create new one, by clicking Register button.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.textUsername.Clear();
                this.textPassword.Clear();
            }
            // Credentials were correct -> log new user in
            else
            {
                await _mainForm.UserChanged(_newUser);
                _mainForm.CloseChildForm();
            }
        }

        // Handles the click event on 'registerUserBtn'.
        private void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new RegisterForm(_mainForm));
        }

        #endregion

        /// <summary>
        /// Checks users in database, if a user with 'username' a password 'pass' exists - returns this user, null otherwise.
        /// </summary>
        /// <param name="username">Username to be "checked".</param>
        /// <param name="pass">Password for account with username 'username'.</param>
        /// <returns>User if matched, null otherwise.</returns>
        private async Task<User> LoginUser(string username, string pass)
        {
            using (var _dataContext = new MessengerContext())
            {
                return await _dataContext.Users
                    .FirstOrDefaultAsync(usr => usr.Username == username && usr.Password == pass);
            }
        }
    }
}
