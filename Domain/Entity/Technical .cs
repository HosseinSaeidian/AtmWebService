namespace atmservice.Domain.Entity
{
    public class Technical  : Register<int>
    {
        public string AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public string BankName { get; set; }
      
    }
}