namespace atmservice.Domain.Entity
{
    public class Register: Entity<uint>
    {
        public string? FullName { get; set; }
        public string? FatherName { get; set; }
        public string? NathionalCode { get; set; }
        public string? Email { get; set; }


        public string? AccountNumber { get; set; }
        public string? AccountOwner { get; set; }
        public string? BankName { get; set; }


        #region Connection

        public LoginInfo LoginInfoNa { get; set; }

        #endregion
    }
}