namespace AppCuponera.Models
{
    public class CouponUsage
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public Coupon? Coupon { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime UsageDate { get; set; } = DateTime.Now;
        public decimal? TransactionAmount { get; set; }
    }
}