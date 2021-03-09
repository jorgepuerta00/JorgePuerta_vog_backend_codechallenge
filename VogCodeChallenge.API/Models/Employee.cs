namespace VogCodeChallenge.API.Models
{
    using Repository;

    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string ResidenceAddress { get; set; }
    }
}
