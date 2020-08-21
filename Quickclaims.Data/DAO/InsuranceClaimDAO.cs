using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quickclaims.Data.IDAO;

namespace Quickclaims.Data.DAO
{
    public class InsuranceClaimDAO : IInsuranceClaimDAO
    {
        private QuickclaimsEntities _context;

        public InsuranceClaimDAO()
        {
            _context = new QuickclaimsEntities();
        }

        public IList<Car_Insurance_Claim> GetInsuranceClaims()
        {
            IQueryable<Car_Insurance_Claim> _claims;

            _claims = from claimlist
                      in _context.Car_Insurance_Claim
                      select claimlist;

            return _claims.ToList();
        }
    }
}
