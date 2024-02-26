using Nop.Web.Framework.Models;

namespace Nop.Plugin.Test.DistOfCustByCountryPlugin.Models;
public record CustomersDistribution : BaseNopModel
{
    /// <summary>
    /// Country based on the billing address.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Number of customers from specific country.
    /// </summary>
    public int NoOfCustomers { get; set; }
}
