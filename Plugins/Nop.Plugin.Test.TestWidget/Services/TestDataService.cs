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

        public async Task<List<UsersDataModel>> GetCustomersDataAsync()
        {
            var customers = await _customerService.GetAllCustomersAsync();

            var usersData = customers.Select(customer => new UsersDataModel
            {
                Id = customer.Id,
                Email = customer.Email,
                FullName = $"{customer.FirstName} {customer.LastName}",
                Phone = customer.Phone
            }).ToList();

            return usersData.Where(x => !string.IsNullOrEmpty(x.FullName.Trim())).ToList();
        }
    }
}