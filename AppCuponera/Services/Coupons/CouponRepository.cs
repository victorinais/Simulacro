using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuponera.Data;
using AppCuponera.Models;

namespace AppCuponera.Services.Coupons
{
    public class CouponRepository : ICouponRepository
    {
        public readonly BaseContext _context;
        public CouponRepository(BaseContext context)
        {
            _context = context;
        }

        public void Add(Coupon coupon)
        {
            _context.Coupons.Add(coupon);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Coupon> GetAll()
        {
            var result = _context.Coupons.ToList();
            return result;
        }

        public Coupon GetById(int id)
        {
            var result = _context.Coupons.FirstOrDefault(c => c.Id == id);
            return result!;
        }

        public void Update(Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}