using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Api.Models;
using Customer.Api.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Customer.Api.Controllers
{
    [Route("api/[controller]")]
    public class DomainController : Controller
    {
        //api//Domain/DomainStatus
        [HttpGet("DomainStatus")]
        public IEnumerable<CustomerDomainStatusModel> GetDomainStatus()
        {
                var domainStatus = new CustomerDomainRepository().GetCustomerDomainStatusModel();

                return domainStatus; 
        }

        [HttpGet("/Status/{id:int}")]
        public CustomerDomainStatusModel GetStatus(int id)
        {
            return new CustomerDomainRepository().GetCustomerDomainStatusModelId(id);
        }

        //api//Domain/DomainType
        [HttpGet("DomainType")]
        public IEnumerable<CustomerDomainTypeModel> GetDomainType()
        {
            var domainStatus = new CustomerDomainRepository().GetCustomerDomainTypeModel();

            return domainStatus;
        }

        [HttpGet("/Type/{id:int}")]
        public CustomerDomainTypeModel GetType(int id)
        {
            return new CustomerDomainRepository().GetCustomerDomainTypeModelId(id);
        }
    }
}

