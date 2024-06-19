using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuponera.Models;
using AppCuponera.Services.Coupons;
using Microsoft.AspNetCore.Mvc;

namespace AppCuponera.Controllers.Coupons
{
    public class CouponCreateController : ControllerBase
    {
        private readonly ICouponRepository _couponRepository;
        public CouponCreateController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        [HttpPost]
        [Route("api/coupons/create")]
        public IActionResult CreateCoupon([FromBody] Coupon coupon)
        {
            _couponRepository.Add(coupon);
            return Ok(new { message = "El cupón se ha creado éxitosamente.", coupon = coupon });
        }
    }
}