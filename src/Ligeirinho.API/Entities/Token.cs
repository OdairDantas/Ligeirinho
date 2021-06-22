using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ligeirinho.API.Entities
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public double ExpiresIn { get; set; }
        public string TokenType { get; set; }
    }
}
