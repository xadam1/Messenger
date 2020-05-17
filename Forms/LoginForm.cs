using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger.Forms;

namespace Messenger
{
    public partial class LoginForm : Form
    {
        private MainForm _mainForm;
        private MD5CryptoServiceProvider md5Encrypter = new MD5CryptoServiceProvider();


        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(MainForm mainForm) : this()
        {
            this._mainForm = mainForm;
            _mainForm.ChangeChildTitle("Log In");
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            string _username = textUsername.Text;
            string _pass = textPassword.Text;

            //var _hashedPass = Encoding.ASCII.GetString(md5Encrypter.ComputeHash(Encoding.ASCII.GetBytes(_pass)));

            Console.WriteLine($"DEBUG:\nUsername={_username}\nPassword={_pass}");

            var _userMatch = LoginUser(_username, _pass);

            // User does not exists
            if (_userMatch == null)
            {
                MessageBox.Show("Username or Password is incorrect!\n\n" +
                                "If you don't have account yet, please create new one, by clicking Register button.",
                    "Error");

                this.textUsername.Clear();
                this.textPassword.Clear();
            }

            else
            {
                _mainForm.UserChanged(_userMatch);
                _mainForm.CloseChildForm();
            }

        }


        private User LoginUser(string username, string pass)
        {
            using (var _dataContext = new MessengerContext())
            {
                return _dataContext.Users
                    .Where(usr => usr.Username == username && usr.Password == pass)
                    .Select(x => x as User)
                    .FirstOrDefault();
            }
        }


        private void registerUserBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new RegisterForm(_mainForm));
        }
    }
}
