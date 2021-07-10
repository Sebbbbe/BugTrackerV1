


using Microsoft.AspNetCore.Identity;


namespace Domain.AuthenticationModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

        }
      
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
