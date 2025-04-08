using MemberSystem.Models.ViewModels;
using MemberSystem.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MemberSystem.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(MemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                _memberService.Register(model);
                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
