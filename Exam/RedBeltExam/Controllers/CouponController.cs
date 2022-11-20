using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RedBeltExam.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace UserController.Controllers;

public class CouponController : Controller
{
    private MyContext db;

    public CouponController(MyContext context)
    {
        db = context;
    }

    [HttpGet("coupon/add")]
    public IActionResult AddCouponPage()
    {
        User? loggedUser = db.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));

        if (loggedUser != null)
        {
            ViewBag.User = loggedUser;
            return View("AddCouponPage");
        }
        return RedirectToAction("Index", "Home");
    }

    [HttpPost("coupon/createcoupon")]
    public IActionResult CreateCoupon(Coupon newcoupon)
    {
        if(ModelState.IsValid)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            if (sessionId != null)
            {
                newcoupon.UserId = (int)sessionId;
                db.Coupons.Add(newcoupon);
                db.SaveChanges();
                return RedirectToAction("Dashboard", "Home");
            }
        }
        return View("AddCouponPage");
    }
}