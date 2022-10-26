using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlinesApp.Models
{
    public class BookTicket
    {
        [Key]
        public int PassengerId { get; set; }
        public int flightNo { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public virtual Airline Airline { get; set; }
    }
}
