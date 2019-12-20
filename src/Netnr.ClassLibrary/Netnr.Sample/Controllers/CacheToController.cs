using System;
using Microsoft.AspNetCore.Mvc;

namespace Netnr.Sample.Controllers
{
    /// <summary>
    /// 缓存
    /// </summary>
    [Route("[controller]/[action]")]
    public class CacheToController : Controller
    {
        /// <summary>
        /// 缓存的相对过期
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResultVM Sliding()
        {
            var vm = new ActionResultVM();

            var dt = Core.CacheTo.Get("123") as DateTime?;
            if (dt == null)
            {
                dt = DateTime.Now;

                //5秒 相对过期
                Core.CacheTo.Set("123", dt, 5);
            }

            vm.data = dt;

            return vm;
        }
        
        /// <summary>
         /// 缓存的绝对过期
         /// </summary>
         /// <returns></returns>
        [HttpGet]
        public ActionResultVM Absolute()
        {
            var vm = new ActionResultVM();

            var dt = Core.CacheTo.Get("456") as DateTime?;
            if (dt == null)
            {
                dt = DateTime.Now;

                //5秒 绝对过期
                Core.CacheTo.Set("456", dt, 5, false);
            }

            vm.data = dt;

            return vm;
        }
    }
}