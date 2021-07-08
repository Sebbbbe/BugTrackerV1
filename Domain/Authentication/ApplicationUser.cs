using Microsoft.AspNet.Identity.EntityFramework;


namespace Domain.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
