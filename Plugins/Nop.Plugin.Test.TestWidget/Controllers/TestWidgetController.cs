using Nop.Plugin.Test.TestWidget.Services;
using Nop.Web.Framework.Controllers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Test.TestWidget.Controllers
{
    public class TestWidgetController : BasePluginController
    {
        private readonly ITestDataService _testDataService;

        public TestWidgetController(ITestDataService testDataService)
        {
            _testDataService = testDataService;
        }

        public ActionResult Configure()
        {
            return View("~/Plugins/Test.TestWidget/Views/Configure.cshtml");
        }

        public async Task<ActionResult> Index()
        {
            var data = await _testDataService.GetCustomersDataAsync();

            return View("~/Plugins/Test.TestWidget/Views/Index.cshtml", data);
        }
    }
}
