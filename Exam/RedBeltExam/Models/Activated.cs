#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedBeltExam.Models;

public class Activated
{
    [Key]
    public int ActivatedId { get; set; }

    public int CouponId { get; set; }

    public int UserId { get; set; }

    public Coupon? Coupon { get; set; }

    public User? User { get; set; }
}