using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Netnr.Sample.Controllers
{
    /// <summary>
    /// 主控制器
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }

        /// <summary>
        /// 报错
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var id = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return Content(id);
        }
    }
}
