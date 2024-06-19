namespace AppCuponera.Models
{
    public class Purchase 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime Date { get; set; }
        public decimal? Amount { get; set; }
    }
}