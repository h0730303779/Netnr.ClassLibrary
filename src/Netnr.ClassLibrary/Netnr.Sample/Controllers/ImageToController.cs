using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Netnr.Sample.Controllers
{
    /// <summary>
    /// 图片操作
    /// </summary>
    [Route("[controller]/[action]")]
    public class ImageToController : Controller
    {
        /// <summary>
        /// 创建验证码，并记录session
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public FileResult CreateCode()
        {
            //随机码
            var num = Core.RandomTo.NumCode();
            //生成图片
            var bytes = Fast.ImageTo.CreateImg(num);

            //写入 session
            HttpContext.Session.SetString("captcha", num);

            return File(bytes, "image/jpeg");
        }

        /// <summary>
        /// 根据session 校验验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResultVM ValidCode()
        {
            var vm = new ActionResultVM();

            try
            {
                var id = RouteData.Values["id"]?.ToString();
                var cc = HttpContext.Session.GetString("captcha");
                if (string.IsNullOrWhiteSpace(id))
                {
                    vm.Set(ARTag.lack);
                    vm.msg = "验证码不能为空";
                }
                else if (string.IsNullOrWhiteSpace(cc))
                {
                    vm.Set(ARTag.lack);
                    vm.msg = "验证码错误或已过期";
                }
                else if (id == cc)
                {
                    vm.Set(ARTag.success);
                }
                else
                {
                    vm.Set(ARTag.fail);
                    vm.msg = "验证码错误或已过期";
                }
            }
            catch (Exception ex)
            {
                vm.Set(ex);
            }

            return vm;
        }
    }
}