using GCook.Models;
using GCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace GCook.Services;

public class UserService : IUserService
{

    public UserService(
        SignInManager<Usuario> signInManager,
        UserManager<Usuario> userManager,
        ILogger<UserService> logger
    )
    {
        
    }

    public Task<SignInResult> Login(LoginVM login)
    {
        throw new NotImplementedException();
    }

    public Task Logout()
    {
        throw new NotImplementedException();
    }
}
