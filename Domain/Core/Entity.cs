using atmservice.Domain.Core;

namespace atmservice.Domain.Entity
{
    public class Entity<key> : IEntity<key>
    where key : struct
    {
        public key Id {get; set;}
        public DateTime TimeCreated {get; set;} = DateTime.Now;
        public DateTime TimeModify {get; set;}
        public bool IsDeleted {get; set;} = false;
        public string Description {get; set;} = null;
    }
}