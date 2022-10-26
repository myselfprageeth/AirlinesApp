using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlinesApp.Models
{
    public class Airline
    {
        [Key]
        public int flightNo { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public double Fare { get; set; }
        public int TotalSeat { get; set; }
        [ForeignKey("flightNo")]
        public virtual ICollection<BookTicket> BookTickets{ get; set; }
    }
}
