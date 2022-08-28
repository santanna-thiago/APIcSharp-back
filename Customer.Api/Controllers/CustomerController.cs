using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Customer.Api.Models;
using Customer.Api.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Customer.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<CustomerModel> Get()
        {
            return new CustomerRepository().GetCustomers();
        }

        // GET api/Customer/Id
        [HttpGet("{id:int}")]
        public CustomerModel Get(int id)
        {
            return new CustomerRepository().GetCustomer(id);
        }


        // POST api/Customer
        [HttpPost]
        public void Post([FromBody] CustomerModel customerModel)
        {
            new CustomerRepository().CreatNewCustomer(customerModel);

        }



        // PUT api/Customer/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerModel customerModel)
        {
            new CustomerRepository().UpdateCustomer(customerModel);
        }

        // DELETE api/Customer/Id
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            new CustomerRepository().DeleteCustomer(id);
        }
    }
}

