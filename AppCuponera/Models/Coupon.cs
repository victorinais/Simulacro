using System.Text.Json.Serialization;

namespace AppCuponera.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? DiscountType { get; set; }
        public decimal? DiscountValue { get; set; }
        public int UsageLimit { get; set; }
        public decimal? MinPurchaseAmount { get; set; }
        public decimal? MaxPurchaseAmount { get; set; }
        public string? Status { get; set; }
        public int CreatedBy { get; set; }
        public User? User { get; set; }

        [JsonIgnore]
        public List<CouponUsage>? CouponUsages { get; set; }
        [JsonIgnore]
        public List<CouponHistory>? CouponHistories { get; set; }
    }
}