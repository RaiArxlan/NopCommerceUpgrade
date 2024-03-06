using Nop.Services.Plugins;
using Nop.Services.Cms;
using Nop.Services.Localization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Web.Framework.Infrastructure;
using System;
using Nop.Core;
using Nop.Plugin.Test.TestWidget.Components;

namespace Nop.Plugin.Test.TestWidget
{
    public class TestWidget : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => true;

        protected readonly IWebHelper _webHelper;
        protected readonly ILocalizationService _localizationService;

        public TestWidget(IWebHelper webHelper, ILocalizationService localizationService)
        {
            _webHelper = webHelper;
            _localizationService = localizationService;
        }

        /// <summary>
        /// Gets a type of a view component for displaying widget
        /// </summary>
        /// <param name="widgetZone">Name of the widget zone</param>
        /// <returns>View component type</returns>
        public Type GetWidgetViewComponent(string widgetZone)
        {
            return typeof(TestWidgetViewComponent);
        }

        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(
            [
                PublicWidgetZones.HomepageTop
            ]);
        }

        /// <summary>
        /// Gets a configuration page URL
        /// </summary>
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}TestWidget/Configure";
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override async Task InstallAsync()
        {
            await _localizationService.AddOrUpdateLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Id", "Id");
            await _localizationService.AddOrUpdateLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.FullName", "Full Name");
            await _localizationService.AddOrUpdateLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Email", "Customer Email");
            await _localizationService.AddOrUpdateLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Phone", "Phone #");

            await base.InstallAsync();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override async Task UninstallAsync()
        {
            await _localizationService.DeleteLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Id");
            await _localizationService.DeleteLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.FullName");
            await _localizationService.DeleteLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Email");
            await _localizationService.DeleteLocaleResourceAsync("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Phone");

            await base.UninstallAsync();
        }
    }
}
