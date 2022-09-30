using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_6_JWT_refresh_SALT_Pswd.Model
{
    public class RefreshToken
    {
        public string Token { get; set; } = String.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expires { get; set; } = DateTime.Now;



    }
}
