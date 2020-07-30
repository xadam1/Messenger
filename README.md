# Messenger
This is simple chatting application written in C# and built with Windows Forms & local database. To deal with database I used [Entity Framework](https://docs.microsoft.com/en-us/ef/) and [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/).

Application itself is devided into several "sections".

## Welcome Page
<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/default.png" width="500" height="500">
This is the page that will pop up after starting the app. First things first, you have to log in in order to load your messages/send new ones. Clicking on the "Log In..." button will take you to login page.

## Login Page
Here you have few options:
* Log Into your account
    using 'username' and 'password'. Among other checks, I used _simple hashing for the passwords, so the app would not store passwords unprotected_.
* Register new account
    which would bring you to Register page.
    
<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/login.png" width="500" height="500">

You still cannot see or send new messages (until you log in).

## Register Page
Similarly to **login page** here you can also:
* Register
    via username & password. As said before, *password hashing* is implemented.
* Go back to login page

<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/register.png" width="500" height="500">

## After Logging in
<img src="https://github.com/xadam1/Messenger/blob/master/Resources/img/logged_in.png" width="500" height="500">
