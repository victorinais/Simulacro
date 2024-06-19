using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuponera.Models;
using AppCuponera.Services.Coupons;
using Microsoft.AspNetCore.Mvc;

namespace AppCuponera.Controllers.Coupons
{
    public class CouponUpdateController : ControllerBase
    {
        private readonly ICouponRepository _couponRepository;
        public CouponUpdateController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        [HttpPut]
        [Route("api/coupons/update/{id}")]
        public IActionResult UpdateCoupon(int id, [FromBody] Coupon coupon)
        {
            var couponToUpdate = _couponRepository.GetById(id);

            couponToUpdate.Name = coupon.Name;
            couponToUpdate.Description = coupon.Description;
            couponToUpdate.StartDate = coupon.StartDate;
            couponToUpdate.EndDate = coupon.EndDate;
            couponToUpdate.DiscountType = coupon.DiscountType;
            couponToUpdate.DiscountValue = coupon.DiscountValue;
            couponToUpdate.UsageLimit = coupon.UsageLimit;
            couponToUpdate.MinPurchaseAmount = coupon.MinPurchaseAmount;
            couponToUpdate.MaxPurchaseAmount = coupon.MaxPurchaseAmount;
            couponToUpdate.Status = coupon.Status;
            couponToUpdate.UserId = coupon.UserId;

            _couponRepository.Update(couponToUpdate);
            return Ok(new { message = "El cupón se actulizó éxitosamente." });
        }
    }
}