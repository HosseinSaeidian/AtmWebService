namespace atmservice.Domain.Entity
{
    public class Register<key> : Entity<key>
    where key : struct
    
    {
         public string FullName { get; set; }
         public string FatherName { get; set; }
         public string NathionalCode { get; set; }
         public string Email { get; set; }
         public string UserName { get; set; }
         public string Password { get; set; }
         public bool AllowedRegister { get; set; } = false; // this is prop for allowing the users to register
         public bool AllowedActivity { get; set; } = false;  // this is prop for allowing the users to activity
         
    }
}