using System;
using Microsoft.AspNetCore.Mvc;

namespace Netnr.Sample.Controllers
{
    /// <summary>
    /// 输出日志
    /// </summary>
    [Route("[controller]/[action]")]
    public class ConsoleToController : Controller
    {
        /// <summary>
        /// 输出日志信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResultVM Index()
        {
            var vm = new ActionResultVM();

            Core.ConsoleTo.Log(DateTime.Now + Environment.NewLine + DateTime.Now);

            vm.Set(ARTag.success);

            return vm;
        }
    }
}