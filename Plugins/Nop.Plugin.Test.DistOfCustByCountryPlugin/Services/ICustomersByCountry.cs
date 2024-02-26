using Nop.Plugin.Test.DistOfCustByCountryPlugin.Models;

namespace Nop.Plugin.Test.DistOfCustByCountryPlugin.Services;
public interface ICustomersByCountry
{
    Task<List<CustomersDistribution>> GetCustomersDistributionByCountryAsync();
}
