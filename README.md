# Messenger
This is simple chatting application written in C# and built with Windows Forms & local database. To deal with database I used [Entity Framework](https://docs.microsoft.com/en-us/ef/) and [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/).

Application itself is devided into several "sections".

### Welcome Page
This is the page that will pop up after starting the app. First things first, you have to log in in order to load your messages/send new ones. Clicking on the "Log In..." button will take you to login page.

<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/default.png" width="500" height="500">


### Login Page
Here you have few options:
* Log Into your account
    using 'username' and 'password'. Among other checks, I used _simple hashing for the passwords, so the app would not store passwords unprotected_.
* Register new account
    which would bring you to Register page.
    
<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/login.png" width="500" height="500">

You still cannot see or send new messages (until you log in).

### Register Page
Similarly to **login page** here user is able to:
* Register
    via username & password. As said before, *password hashing* is implemented.
* Go back to login page

<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/register.png" width="500" height="500">

### After Logging in
User's messages will be loaded from the database. That means users that have conversation with currently logged in user, will be displayed in the left panel. After clicking on another's user name, chat window will pop up.

<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/logged_in.png" width="500" height="500">

Now you can also send new messages to other users, *if a user selects another user, with already opened conversation - this conversation is opened.*

<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/select_msg.png" width="500" height="500">

### Chat Window
Finally this is the look of *chatting window* itself. Note that messages are color coded according to sender.

<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/chat_window.png" width="500" height="500">
