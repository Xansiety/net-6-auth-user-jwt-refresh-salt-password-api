using System.ComponentModel.DataAnnotations;

namespace Net_6_JWT_refresh_SALT_Pswd.Model;

public class UserLoginRequest
{
    [Required]
    public string Username { get; set; } = String.Empty;

    [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters")]
    public string Password { get; set; } = String.Empty; 
   
}
