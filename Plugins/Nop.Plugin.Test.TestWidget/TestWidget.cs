using Nop.Core.Plugins;
using Nop.Services.Cms;
using Nop.Services.Localization;
using System.Collections.Generic;
using System.Web.Routing;

namespace Nop.Plugin.Test.TestWidget
{
    public class TestWidget : BasePlugin, IWidgetPlugin
    {
        public TestWidget()
        {

        }

        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        public IList<string> GetWidgetZones()
        {
            return new List<string>
            {
                "home_page_top"
            };
        }

        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "TestWidget";
            routeValues = new RouteValueDictionary { { "Namespaces", "Nop.Plugin.Test.TestWidget.Controllers" }, { "area", null } };
        }

        /// <summary>
        /// Gets a route for displaying widget
        /// </summary>
        /// <param name="widgetZone">Widget zone where it's displayed</param>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Index";
            //actionName = "Configure";
            controllerName = "TestWidget";
            routeValues = new RouteValueDictionary
            {
                {"Namespaces", "Nop.Plugin.Test.TestWidget.Controllers"},
                {"area", null},
                {"widgetZone", widgetZone}
            };
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {
            this.AddOrUpdatePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Id", "Id");
            this.AddOrUpdatePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.FullName", "Full Name");
            this.AddOrUpdatePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Email", "Customer Email");
            this.AddOrUpdatePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Phone", "Phone #");

            base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {
            this.DeletePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Id");
            this.DeletePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.FullName");
            this.DeletePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Email");
            this.DeletePluginLocaleResource("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Phone");

            base.Uninstall();
        }
    }
}
