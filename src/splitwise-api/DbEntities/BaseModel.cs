namespace Splitwise.DbEntities
{
    public abstract class BaseModel
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? ModifiedAtUtc { get; set; }
    }
}
