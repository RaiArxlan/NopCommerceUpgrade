using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Plugin.Test.TestWidget.Models
{
    public class UsersDataModel
    {
        [NopResourceDisplayName("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Id")]
        public int Id { get; set; }

        [NopResourceDisplayName("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.FullName")]
        public string FullName { get; set; }

        [NopResourceDisplayName("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Email")]
        public string Email { get; set; }

        [NopResourceDisplayName("Plugin.Test.TestWidget.Models.UsersDataModel.Fields.Phone")]
        public string Phone { get; set; }
    }
}
