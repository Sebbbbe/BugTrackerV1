﻿using Microsoft.AspNet.Identity.EntityFramework;



namespace Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
