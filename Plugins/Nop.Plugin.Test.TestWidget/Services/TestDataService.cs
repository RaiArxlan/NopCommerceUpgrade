using Nop.Core.Domain.Customers;
using Nop.Plugin.Test.TestWidget.Models;
using Nop.Services.Common;
using Nop.Services.Customers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Test.TestWidget.Services
{
    public class TestDataService : ITestDataService
    {
        private readonly ICustomerService _customerService;

        public TestDataService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public Task<List<UsersDataModel>> GetCustomersDataAsync()
        {
            var customers = _customerService.GetAllCustomers();

            var usersData = customers.Select(customer => new UsersDataModel
            {
                Id = customer.Id,
                Email = customer.Email,
                FullName = customer.GetFullName(),
                Phone = customer.GetAttribute<string>(SystemCustomerAttributeNames.Phone)
            }).ToList();

            return Task.FromResult(usersData.Where(x => !string.IsNullOrEmpty(x.FullName)).ToList());
        }
    }
}