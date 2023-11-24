using AuthApp;

var userOK = new User()
{
    Login = "user",
    Password = "12345"
};

var userBad = new User()
{
    Login = "admin",
    Password = "123"
};

var auth = new LoggerAuth(new LogToConsole());

Console.WriteLine(auth.Auth(userOK) ? "OK" : "ERROR");
Console.WriteLine(auth.Auth(userBad) ? "OK" : "ERROR");
