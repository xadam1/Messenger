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


        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(MainForm mainForm) : this()
        {
            this._mainForm = mainForm;
            _mainForm.ChangeChildTitle("Log In");
        }


        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string _username = textUsername.Text;
            string _pass = textPassword.Text;

            var _hashedPass = Encoding.ASCII.GetString(_md5Crypto.ComputeHash(Encoding.ASCII.GetBytes(_pass)));

            Console.WriteLine($"DEBUG:\nUsername={_username}\nPassword={_pass}\nHashedPass={_hashedPass}");

            // TODO Change for hashed pass version
            var _newUser = await LoginUser(_username, _pass);

            // User not found
            if (_newUser == null)
            {
                MessageBox.Show("Username or Password is incorrect!\n\n" +
                                "If you don't have account yet, please create new one, by clicking Register button.",
                    "Error");

                this.textUsername.Clear();
                this.textPassword.Clear();
            }
            // Log in new user
            else
            {
                _mainForm.UserChanged(_newUser);
                _mainForm.CloseChildForm();
            }
        }


        // Returns null if user not found, <User> else
        private async Task<User> LoginUser(string username, string pass)
        {
            using (var _dataContext = new MessengerContext())
            {
                return await _dataContext.Users
                    .FirstOrDefaultAsync(usr => usr.Username == username && usr.Password == pass);
            }
        }


        private void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new RegisterForm(_mainForm));
        }

    }
}
