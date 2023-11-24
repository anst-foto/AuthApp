namespace AuthApp;

public class LoggerAuth : IAuth
{
    private readonly SimpleAuth _auth;
    private readonly ILogger _logger;

    public LoggerAuth(ILogger logger)
    {
        _auth = new SimpleAuth();
        _logger = logger;
    }

    public bool Auth(User user)
    {
        var result = _auth.Auth(user);
        if (result)
        {
            _logger.Success($"{user.Login}: auth success");
        }
        else
        {
            _logger.Error($"{user.Login}: auth error");
        }

        return result;
    }
}