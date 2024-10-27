namespace SoloarTech.Models
    {
    // ORM Object-Relational Mapper -> Entity Framework Core -> SQL Server
    public class Customer
        {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Address { get; set; }

        // Navigation Property
        public required List<Order> Orders { get; set; }
        }
    }
