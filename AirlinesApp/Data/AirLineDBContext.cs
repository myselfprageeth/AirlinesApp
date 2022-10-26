using AirlinesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AirlinesApp.Data
{
    public class AirLineDBContext: DbContext
    {
        public AirLineDBContext(DbContextOptions<AirLineDBContext> options):base(options)
        {

        }

        public DbSet<CustomerCare> CustomerCare { get; set; }

        public DbSet<Airline> Airlines { get; set; }

        public DbSet<BookTicket> BookTicket { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<CustomerCare> customerCares = new();
            customerCares.Add(new CustomerCare()
            {
                Id = 1,
                Email = "myselfprageeth@gmail.com",
                PhoneNumber = 9746689742
            });

            List<Airline> airlines = new();
            airlines.Add(new Airline()
            {
                flightNo=101,
                Source="Source1",
                Destination="Destination1",
                Fare=100,
                TotalSeat=108
            });

            airlines.Add(new Airline()
            {
                flightNo = 102,
                Source = "Source2",
                Destination = "Destination2",
                Fare = 100,
                TotalSeat = 108
            });

            airlines.Add(new Airline()
            {
                flightNo = 103,
                Source = "Source3",
                Destination = "Destination3",
                Fare = 100,
                TotalSeat = 108
            });

            List<BookTicket> bookTickets = new();
            bookTickets.Add(new BookTicket()
            {
                PassengerId=1,
                flightNo=101,
                PassengerFirstName="Prageeth",
                PassengerLastName="Rajan",
                City="Thalassery",
                Age=27
            });

            modelBuilder.Entity<CustomerCare>().HasData(customerCares);
            modelBuilder.Entity<Airline>().HasData(airlines);
            modelBuilder.Entity<BookTicket>().HasData(bookTickets);
            base.OnModelCreating(modelBuilder);
        }
    }
}
