using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RedBeltExam.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace UserController.Controllers;

public class UserController : Controller
{
    private MyContext db;

    public UserController(MyContext context)
    {
        db = context;
    }

    [HttpGet("account/view")]
    public IActionResult ViewAccount()
    {
        User? account = db.Users.FirstOrDefault(a => a.UserId == HttpContext.Session.GetInt32("userId"));
        if (account != null)
        {
            ViewBag.Account = account;
            List<Activated> allActivations = db.Activations.Where(a => a.UserId == account.UserId).ToList();
            int allActivationsCount = allActivations.Count;
            ViewBag.Activations = allActivationsCount;
            List<Coupon> allcoupons = db.Coupons
            .Include(c => c.Creator)
            .Include(c => c.CouponActivations)
            .ToList();
            return View("ViewAccount", allcoupons);
        }
        return RedirectToAction("Index", "Home");
    }

    [HttpPost("activate/{couponId}")]
    public IActionResult Activate(int couponId)
    {
        User? account = db.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));

        if (account == null)
        {
            return RedirectToAction("Index", "Home");
        }

        Activated newActivation = new Activated()
        {
            UserId = (int)account.UserId,
            CouponId = couponId
        };
        db.Activations.Add(newActivation);
        db.SaveChanges();
        return RedirectToAction("Dashboard", "Home");
    }
}
