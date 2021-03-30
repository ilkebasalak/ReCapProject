using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
   public class AccessToken
    {
        //Kullanıcı giriş yaptıktan sonra token veririz.
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
