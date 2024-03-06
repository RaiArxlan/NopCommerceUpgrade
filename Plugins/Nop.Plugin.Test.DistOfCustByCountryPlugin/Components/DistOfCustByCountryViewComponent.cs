using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Test.DistOfCustByCountryPlugin.Models;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Test.DistOfCustByCountryPlugin.Components;
public class DistOfCustByCountryViewComponent : NopViewComponent
{
    /// <summary>
    /// Invoke the widget view component
    /// </summary>
    /// <param name="widgetZone">Widget zone</param>
    /// <param name="additionalData">Additional parameters</param>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the view component result
    /// </returns>
    public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
    {
        // dummy async call
        await Task.CompletedTask;

        // dummy data
        var model = new List<CustomersDistribution>
        {
            new CustomersDistribution
            {
                Country = "USA",
                NoOfCustomers = 100
            },
            new CustomersDistribution
            {
                Country = "UK",
                NoOfCustomers= 200
            },
            new CustomersDistribution
            {
                Country = "India",
                NoOfCustomers = 300
            },
            new CustomersDistribution
            {
                Country = "Australia",
                NoOfCustomers = 400
            },
            new CustomersDistribution
            {
                Country = "Canada",
                NoOfCustomers = 500
            }
        };

        return View("~/Plugins/Test.DistOfCustByCountryPlugin/Views/Index.cshtml", model);
    }
}
