using MernisService;
using StarbucksAndNero.Abstract;
using StarbucksAndNero.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisService.KPSPublicSoapClient;

namespace StarbucksAndNero.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var res = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);

         
            return res.Body.TCKimlikNoDogrulaResult;
        }
    }
}
