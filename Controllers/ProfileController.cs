using ProfileManagement.Models;
using Microsoft.AspNetCore.Mvc;
using ProfileManagement.Models.ViewModels;

namespace ProfileManagement.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profiles()
        {
            var profiles = Profile.Profiles;
            var result = profiles.Select(p => new ProfileViewModel
            {
                Name = p.Name,
                Email = p.Email,
                PhoneNumber = p.PhoneNumber,
            }).ToList();
            return View(result);
        }
    }
}
