using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quickclaims.Data;
using Quickclaims.Data.IDAO;
using Quickclaims.Data.DAO;

namespace Quickclaims.Services.Service
{
    public class InsuranceClaimService : Quickclaims.Services.IService.IInsuranceClaimService
    {
        private InsuranceClaimDAO _insuranceClaimDAO;

        public InsuranceClaimService(){

            _insuranceClaimDAO = new InsuranceClaimDAO();
        }

        public IList<Car_Insurance_Claim> GetInsuranceClaims()
        {
            return _insuranceClaimDAO.GetInsuranceClaims();
        }

    }
}
