using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuponera.Models;
using AppCuponera.Services.Coupons;
using Microsoft.AspNetCore.Mvc;

namespace AppCuponera.Controllers.Coupons
{
    public class CouponsController : ControllerBase
    {
        private readonly ICouponRepository _couponRepository;
        public CouponsController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        [HttpGet]
        [Route("api/coupons")]
        public IEnumerable<Coupon> GetCoupons()
        {
            return _couponRepository.GetAll();
        }
    }
}