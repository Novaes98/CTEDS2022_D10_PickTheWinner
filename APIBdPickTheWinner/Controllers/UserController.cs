using APIBdPickTheWinner.Contexts;
using APIBdPickTheWinner.Interface;
using APIBdPickTheWinner.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace APIBdPickTheWinner.Controllers;

[Route("api/[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    private IUser UserRepository { get; set; }

    public UserController(Context ctx)
    {
        UserRepository = new UserRepository(ctx);
    }

    [HttpGet]
    public IActionResult GetResult()
    {
        return Ok(UserRepository.List());
    }

}
