namespace AuthenticationService.Services;

using Grpc.Core;

public class AuthenticateService : Authenticate.AuthenticateBase
{
    private readonly ILogger<AuthenticateService> _logger;
    public AuthenticateService(ILogger<AuthenticateService> logger)
    {
        _logger = logger;
    }

    public override Task<AuthenticateReply> Login(AuthenticateRequest request, ServerCallContext context)
    {
        return Task.FromResult(new AuthenticateReply
        {
            Success = true,
            Id = 1,
            Message = $"{request.Username} logged in"
        });
    }
}