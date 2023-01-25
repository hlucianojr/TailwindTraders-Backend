using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tailwind.Traders.Profile.Api2.Models
{
    public class BasicAuthenticationOptions : AuthenticationSchemeOptions
    {
        public string Name { get; set; }
    }
}
