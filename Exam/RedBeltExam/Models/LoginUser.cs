#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedBeltExam.Models;

public class LoginUser
{
    [EmailAddress]
    [Required(ErrorMessage = "is required")]
    [Display(Name = "LoginEmail")]
    public string LoginEmail { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "LoginPassword")]
    [Required(ErrorMessage = "is required")]
    public string LoginPassword { get; set; }
}