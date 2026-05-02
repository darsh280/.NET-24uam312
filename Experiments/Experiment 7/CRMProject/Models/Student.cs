using System.ComponentModel.DataAnnotations;

public class Student{
    [Required(ErrorMessage ="name field required")]
    public string Name{get; set;}
    [Range(18,60)]
    public int Age {get; set;}
    [EmailAddress(ErrorMessage ="Email field required")]
    public string Email{get; set;}
    [StringLength(20)]
    public string Password{get; set;}
}