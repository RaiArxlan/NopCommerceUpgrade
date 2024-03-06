using Nop.Plugin.Test.TestWidget.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Plugin.Test.TestWidget.Services
{
    public interface ITestDataService
    {
        Task<List<UsersDataModel>> GetCustomersDataAsync();
    }
}