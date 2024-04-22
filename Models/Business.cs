namespace WebAppTest.Models
{
    [Table("Business")]
    public class Business
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Websites { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
