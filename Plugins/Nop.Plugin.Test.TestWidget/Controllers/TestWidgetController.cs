using Nop.Plugin.Test.TestWidget.Services;
using Nop.Web.Framework.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Plugin.Test.TestWidget.Controllers
{
    public class TestWidgetController : BasePluginController
    {
        public TestWidgetController()
        {
        }

        public ActionResult Configure()
        {
            return View("~/Plugins/Test.TestWidget/Views/Configure.cshtml");
        }
    }
}
