using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Test.TestWidget.Services;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Test.TestWidget.Components;
public class TestWidgetViewComponent : NopViewComponent
{
    private readonly ITestDataService _testDataService;

    public TestWidgetViewComponent(ITestDataService testDataService)
    {
        _testDataService = testDataService;
    }

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
        var data = await _testDataService.GetCustomersDataAsync();

        return View("~/Plugins/Test.TestWidget/Views/Index.cshtml", data);
    }
}
