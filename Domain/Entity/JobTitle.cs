namespace atmservice.Domain.Entity
{
    public class JobTitle : Entity<byte>
    {
        public string Name { get; set; }
        

        #region Connection
        
        public IEnumerable<LoginInfo> LoginInfoNa { get; set; }


        #endregion
    }
}