using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppTest.Models
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
