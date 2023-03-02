using StarbucksAndNero.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksAndNero.Abstract
{
    public interface ICustomerCheckService
    {
        Task<bool> CheckIfRealPerson(Customer customer);
    }
} 
