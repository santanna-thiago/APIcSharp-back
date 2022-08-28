using System;
using Customer.Api.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Customer.Api.Repositories
{
    public class CustomerDomainRepository
    {
        public string connectionString = "Data Source=localhost;Initial Catalog=master;User Id=sa;Password=customerApi@2022;TrustServerCertificate=true";

        public IEnumerable<CustomerDomainStatusModel> GetCustomerDomainStatusModel()
        {
            var customerDomainStatus = new List<CustomerDomainStatusModel>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    customerDomainStatus = connection.Query<CustomerDomainStatusModel>(@"SELECT ID, NAME FROM DOMAIN_STATUS")
                        .ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return customerDomainStatus;
        }

        public CustomerDomainStatusModel GetCustomerDomainStatusModelId(int id)
        {

            var customerDomainStatus = new CustomerDomainStatusModel();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    customerDomainStatus = connection.Query<CustomerDomainStatusModel>("SELECT * FROM DOMAIN_STATUS WHERE Id = @Id", new { id })
                        .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerDomainStatus;
        }

        public IEnumerable<CustomerDomainTypeModel> GetCustomerDomainTypeModel()
        {
            var customerDomainType = new List<CustomerDomainTypeModel>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    customerDomainType = connection.Query<CustomerDomainTypeModel>(@"SELECT ID, NAME FROM DOMAIN_TYPE")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerDomainType;
        }

        public CustomerDomainTypeModel GetCustomerDomainTypeModelId(int id)
        {

            var customerDomainType = new CustomerDomainTypeModel();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    customerDomainType = connection.Query<CustomerDomainTypeModel>("SELECT * FROM DOMAIN_TYPE WHERE Id = @Id", new { id })
                        .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerDomainType;
        }
    }
}

