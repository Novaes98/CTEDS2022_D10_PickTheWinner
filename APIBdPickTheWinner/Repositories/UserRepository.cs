using Microsoft.AspNetCore.Identity;
using APIBdPickTheWinner.Interface;
using APIBdPickTheWinner.Domain;
using APIBdPickTheWinner.Contexts;

namespace APIBdPickTheWinner.Repositories;

public class UserRepository : IUser
{
    private readonly Context ctx;

    public UserRepository(Context ctx)
    {
        this.ctx = ctx;
    }

    public List<User> List()
    {
        return ctx.User.ToList();
    }

    public bool LoginUserPwd(string userEmail, string pwd)
    {
        if (ctx.User.Any(User => User.Email == userEmail && User.Password == pwd))
        {
            return true;
        }
    
        return false;
    }
}

