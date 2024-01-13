using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc.Controllers;

public class AuthController : Controller
{
    private readonly UserRepository userRepository;

    public AuthController (UserRepository userRepository)
    {
        userRepository = userRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string email, string password)
    {
        var user = userRepository.GetUserByEmailAndPassword(email, password);

        if (user != null)
        {
            return RedirectToAction("Index", "Home");
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Invalid email or password");
            return View();
        }
    }
}