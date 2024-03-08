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
                Id = p.Id,
                Name = p.Name,
                Email = p.Email,
                PhoneNumber = p.PhoneNumber,
                DateofBirth = p.DateofBirth,
            }).ToList();
            return View(result);
        }

        public IActionResult ProfileInfo(int id)
        {
            var profile = Profile.Profiles.SingleOrDefault(x => x.Id == id);
            var result = new ProfileInfoViewModel
            {
                Name = profile.Name,
                Email = profile.Email,
                PhoneNumber = profile.PhoneNumber,
                DateofBirth = profile.DateofBirth
            };
            return View(result);
        }

        [HttpGet]
        public IActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProfile(CreateProfileRequestModel model)
        {
            var result = Profile.AddProfile(model.Name, model.Email, model.PhoneNumber, model.DateofBirth);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //ViewBag.CourseResponse = result.Message;
            return RedirectToAction("Profiles");
        }

       /* public IActionResult Delete(int id)
        {
            var x = _courseService.GetCourse(id);

            if (x == null)
            {
                return NotFound();
            }
            var result = new CourseViewModel
            {
                Id = x.CourseId,
                Name = x.Name,
                Code = x.Code,
                Unit = x.Unit,
                Description = x.Description,
            };
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _courseService.DeleteCourse(id);
            return RedirectToAction(nameof(Index));
        }*/
    }
}
