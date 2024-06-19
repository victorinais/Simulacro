using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuponera.Models;

namespace AppCuponera.Services.Coupons
{
    public interface ICouponRepository
    {
        IEnumerable<Coupon> GetAll();
        Coupon GetById(int id);
        void Add(Coupon coupon);
        void Update(Coupon coupon);
        void Delete(int id);
    }
}