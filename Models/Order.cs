namespace SolarTech.Models
    {
    public class Order
        {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public decimal NetAmount { get; set; }
        public decimal GrossAmount => NetAmount * 1.19M;

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string ImagePath { get; set; }
        }
    }