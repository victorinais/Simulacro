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

        [HttpGet]
        [Route("api/coupons/{id}")]
        public Coupon GetCouponById(int id)
        {
            return _couponRepository.GetById(id);
        }

        /* [HttpGet]
        [Route("api/coupons/list/{date}")]
        public ActionResult<IEnumerable<Coupon>> GetListCouponsByDate(DateTime date)
        {
            var result = _couponRepository.GetListCouponsByDate(date);
            return Ok(new { message = $"En la fecha {date.ToString("yyyy-MM-dd")} se registraron {result.Count()} cupones.", cupones = result });
        } */

        [HttpGet]
        [Route("api/coupons/list")]
        public ActionResult<IEnumerable<Coupon>> GetListCouponsByCriteria(DateTime? date, string status = null, string orderBy = "id",bool descending = false)
        {
            var result = _couponRepository.GetListCouponsByCriteria(date, status, orderBy, descending);
            return Ok(new { message = $"Se encontraron {result.Count()} cupones.", cupones = result });
        }

    }
}