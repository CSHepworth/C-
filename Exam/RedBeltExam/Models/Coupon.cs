#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedBeltExam.Models;

public class Coupon
{
    [Key]
    public int CouponId { get; set; }

    [Display(Name = "Coupon Code")]
    [Required(ErrorMessage = "is required")]
    public string Code { get; set; }

    [Display(Name = "Website")]
    [Required(ErrorMessage = "is required")]
    public string Website { get; set; }

    [Required]
    public int Goal { get; set; }

    [Display(Name = "Description")]
    [Required]
    [MinLength(10, ErrorMessage = "Description must be at least 10 characters")]
    public string Description { get; set; }

    public int UserId { get; set; }
    public User? Creator { get; set; }

    public List<Activated> CouponActivations { get; set; } = new List<Activated>();

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
}