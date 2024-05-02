namespace atmservice.Domain.Entity
{
    public class LoginInfo : Entity<Guid>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool AllowedRegister { get; set; } = false; // this is prop for allowing the users to register and can accept by admin
        public bool AllowedActivity { get; set; } = false;  // this is prop for allowing the users to activity



        #region Connection

        public JobTitle JobTitleNa { get; set; }
        public byte JobTitleId { get; set; }



        public Register RegisterNa { get; set; }
        public uint RegitsterId { get; set; }

        
        #endregion


    }
}