namespace Net_6_JWT_refresh_SALT_Pswd.Model;

public class User
{
    public string UserName { get; set; } = String.Empty;
    public byte[] PasswordHash { get; set; } = new byte[32]; 
    public byte[] PasswordSalt { get; set; } = new byte[32];

    // RJWT
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime TokenCreated { get; set; }
    public DateTime TokenExpires { get; set; }

}
