using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Netnr.Sample.Controllers
{
    /// <summary>
    /// 全局对象
    /// </summary>
    [Route("[controller]/[action]")]
    public class GlobalToController : Controller
    {
        /// <summary>
        /// 获取一些配置信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResultVM Index()
        {
            var vm = new ActionResultVM();

            var dic = new Dictionary<string, object>
            {
                { "WebRootPath", GlobalTo.WebRootPath },
                { "ContentRootPath", GlobalTo.ContentRootPath },
                { "appsettings.json 配置文件取值", GlobalTo.GetValue("Logging:LogLevel:Default") }
            };

            vm.data = dic;

            return vm;
        }
    }
}