using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instruments.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Admin
    {
        public String AdminRole { get; set; }

    }
}
