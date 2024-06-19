using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuponera.Services.Coupons;
using Microsoft.AspNetCore.Mvc;

namespace AppCuponera.Controllers.Coupons
{
    public class CouponDeleteController : ControllerBase
    {
        private readonly ICouponRepository _couponRepository;
        public CouponDeleteController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        [HttpDelete]
        [Route("api/coupons/delete/{id}")]
        public IActionResult DeleteCoupon(int id)
        {
            _couponRepository.Delete(id);
            return Ok(new { message = "El coupon Cambió de estado éxitosamente."});
        }
    }
}