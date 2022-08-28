using System;
using System.Collections.Generic;
using System.Data;
using Customer.Api.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Customer.Api.Repositories
{
    public class CustomerRepository
    {
        public string connectionString = "Data Source=localhost;Initial Catalog=master;User Id=sa;Password=customerApi@2022;TrustServerCertificate=true";


        public IEnumerable<CustomerModel> GetCustomers()
        {
            var customerModels = new List<CustomerModel>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    customerModels = connection.Query<CustomerModel>(@"SELECT * FROM Customers")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerModels;
        }
        public CustomerModel GetCustomer(int id)
        {

            var customerModels = new CustomerModel();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    customerModels = connection.Query<CustomerModel>("SELECT * FROM customers WHERE Id = @Id", new { id })
                        .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerModels;
        }

        public void CreatNewCustomer(CustomerModel customerModel)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {

                    var results = connection.Query("dbo.NewCustomer", new { customerModel.Name, customerModel.Cpf, customerModel.Gender, customerModel.Domain_Status_Id, customerModel.Domain_Type_Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCustomer(CustomerModel customerModel)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {

                    var results = connection.Query("dbo.UpdateCustomer", new { customerModel.Id ,customerModel.Name, customerModel.Cpf, customerModel.Gender, customerModel.Domain_Status_Id, customerModel.Domain_Type_Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteCustomer(int id)
            {
                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                 
                        var results = connection.Query("dbo.DeleteCustomer", new { id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

    }
}






    



