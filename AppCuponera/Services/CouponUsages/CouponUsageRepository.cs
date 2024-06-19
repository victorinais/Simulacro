using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCuponera.Data;
using AppCuponera.Models;

namespace AppCuponera.Services.CouponUsages
{
    public class CouponUsageRepository : ICouponUsageRepository
    {
        public readonly BaseContext _context;
        public CouponUsageRepository(BaseContext context)
        {
            _context = context;
        }
        public void Add(CouponUsage couponUsage)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CouponUsage> GetAll()
        {
            throw new NotImplementedException();
        }

        public CouponUsage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CouponUsage couponUsage)
        {
            throw new NotImplementedException();
        }
    }
}