namespace SoloarTech.Models
    {
    public class Order
        {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string? Description { get; set; }

        public decimal NetAmount { get; set; } // Netto

        public decimal GrossAmount => NetAmount * 1.19M; // Brutto

        // Foreign Key for SQL Server
        public int CustomerId { get; set; }

        // Navigation Property
        public required Customer Customer { get; set; }
        }
    }
