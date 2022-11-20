#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedBeltExam.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Display(Name = "Username")]
    [Required(ErrorMessage = "is required")]
    [MinLength(3, ErrorMessage = "Username Must be at least 3 characters.")]
    public string Username { get; set; }

    [EmailAddress]
    [Display(Name = "Email")]
    [Required(ErrorMessage = "is required")]
    public string Email { get; set; }

    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "is required")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
    public string Password { get; set; }

    [NotMapped]
    [Display(Name = "Confirm Password")]
    [Compare("Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "is required")]
    public string Confirm { get; set; }

    public List<Coupon> UserCoupons { get; set; } = new List<Coupon>();

    public List<Activated> CouponsUsed { get; set; } = new List<Activated>();

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}