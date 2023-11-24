namespace AuthApp;

public sealed class SimpleAuth : IAuth
{
    private const string Login = "user";
    private const string Password = "12345";
    
    public bool Auth(User user)
    {
        return user.Login == Login && user.Password == Password;
    }
}