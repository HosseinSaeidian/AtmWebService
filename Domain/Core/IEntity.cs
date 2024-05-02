namespace atmservice.Domain.Core
{
    public interface IEntity<key>
    where key : struct
    {
        key Id { get; set; }

        public DateTime TimeCreated { get; set; }

        DateTime TimeModify { get; set; }

        // ture it means : deleted and false it means : did not deleted and default is false
        bool IsDeleted { get; set; }

        string Description { get; set; }
    }
}