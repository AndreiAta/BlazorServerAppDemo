using System.ComponentModel.DataAnnotations;

namespace BlazorServerAppDemo.Data;

//public record Participant(string FullName, string Email, string PhoneNumber);

public class Participant
{
    [Required]
    public string FullName { get; set;}

    [Required]
    public string Email { get; set;}

    [Required]
    public string PhoneNumber { get; set;}

}
