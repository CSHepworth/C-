using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RedBeltExam.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace RedBeltExam.Controllers;

public class HomeController : Controller
{
    private MyContext db;

    public HomeController(MyContext context)
    {
        db = context;
    }


    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("registeruser")]
    public IActionResult RegisterUser(User newuser)
    {
        if(ModelState.IsValid)
        {
            if(db.Users.Any(e => e.Email == newuser.Email))
            {
                ModelState.AddModelError("Email", "Email is already taken.");
                return View("Index");
            }

            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newuser.Password = Hasher.HashPassword(newuser, newuser.Password);


            db.Users.Add(newuser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("userId", newuser.UserId);
            return RedirectToAction("Dashboard");
        }
        return View("Index");
    }

    [HttpPost("loginuser")]
    public IActionResult LoginUser(LoginUser user)
    {
        if(ModelState.IsValid)
        {
            User? loginUser = db.Users?.FirstOrDefault(e => e.Email == user.LoginEmail);

            if(loginUser == null)
            {
                ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                return View("Index");
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

            var result = hasher.VerifyHashedPassword(user, loginUser.Password, user.LoginPassword);

            if(result == PasswordVerificationResult.Failed)
            {
                ModelState.AddModelError("LoginPassword", "Invalid Password");
                return View("Index");
            }
            HttpContext.Session.SetInt32("userId", loginUser.UserId);
            return RedirectToAction("Dashboard");
        }
        return View("Index");
    }

    [HttpGet("logoutuser")]
    public IActionResult LogoutUser()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [HttpGet("dashboard")]
    public IActionResult Dashboard()
    {
        User? loggedUser = db.Users.FirstOrDefault(e => e.UserId == HttpContext.Session.GetInt32("userId"));

        if (loggedUser != null)
        {
            ViewBag.Account = loggedUser;
            List<Coupon> allCoupons = db.Coupons
            .Include(p => p.Creator)
            .Include(p => p.CouponActivations)
            .ToList();
            return View("Dashboard", allCoupons);
        }
        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
