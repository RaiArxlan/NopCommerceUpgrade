using Nop.Plugin.Test.DistOfCustByCountryPlugin.Models;
using Nop.Services.Common;
using Nop.Services.Customers;
using Nop.Services.Directory;

namespace Nop.Plugin.Test.DistOfCustByCountryPlugin.Services;
public class CustomersByCountry: ICustomersByCountry
{
    private readonly IAddressService _addressService;
    private readonly ICountryService _countryService;
    private readonly ICustomerService _customerService;

    public CustomersByCountry(IAddressService addressService,
        ICountryService countryService,
        ICustomerService customerService)
    {
        _addressService = addressService;
        _countryService = countryService;
        _customerService = customerService;
    }

    public async Task<List<CustomersDistribution>> GetCustomersDistributionByCountryAsync()
    {
        return (await _customerService.GetAllCustomersAsync())
            .Where(c => c.ShippingAddressId != null)
            .Select(async c => new
            {
                (await _countryService.GetCountryByAddressAsync(await _addressService.GetAddressByIdAsync(c.ShippingAddressId ?? 0))).Name,
                c.Username
            })
            .GroupBy(c => c.Result.Name)
            .Select(cbc => new CustomersDistribution { Country = cbc.Key, NoOfCustomers = cbc.Count() }).ToList();
    }
}