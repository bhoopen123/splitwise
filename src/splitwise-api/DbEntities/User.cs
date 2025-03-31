namespace Splitwise.DbEntities
{
    public class User : BaseModel
    {
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Password { get; set; }
    }
}
