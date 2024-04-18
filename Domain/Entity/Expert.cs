namespace atmservice.Domain.Entity
{
    public class Expert : Register<int>
    {
      public byte EpertType { get; set; } = 1;
    }
}