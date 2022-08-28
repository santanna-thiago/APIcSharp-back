using System;
namespace Customer.Api.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Cpf { get; set; }
        public string Gender { get; set; }
        public int Domain_Status_Id { get; set; }
        public int Domain_Type_Id { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
    }
}

