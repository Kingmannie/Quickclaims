using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quickclaims.Data;
using Quickclaims.Data.IDAO;
using Quickclaims.Data.DAO;

namespace Quickclaims.Services.IService
{
    public interface IInsuranceClaimService
    {
        IList<Quickclaims.Data.Car_Insurance_Claim> GetInsuranceClaims();
    }
}
