using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Netnr.Sample.Controllers
{
    /// <summary>
    /// 缓存
    /// </summary>
    [Route("[controller]/[action]")]
    public class OSInfoToController : Controller
    {
        /// <summary>
        /// 获取系统信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResultVM Index()
        {
            var vm = new ActionResultVM();
            try
            {
                vm.data = new Fast.OSInfoTo();
            }
            catch (Exception ex)
            {
                vm.Set(ex);
            }
            return vm;
        }
    }
}