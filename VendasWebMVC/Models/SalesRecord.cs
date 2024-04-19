using VendasWebMVC.Models.Enuns;

namespace VendasWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Departament { get; set; }
        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller departament)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Departament = departament;
        }
    }
}
