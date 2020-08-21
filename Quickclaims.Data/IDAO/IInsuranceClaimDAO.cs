using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickclaims.Data.IDAO
{
    public interface IInsuranceClaimDAO
    {
        IList<Quickclaims.Data.Car_Insurance_Claim> GetInsuranceClaims();
    }
}
