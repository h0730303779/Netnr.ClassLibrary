using System;

namespace Netnr.Core
{
    /// <summary>
    /// 虚拟路径转换为物理路径
    /// </summary>
    public class MapPathTo
    {
#if NET40
        public static string Map(string path)
        {
            return System.Web.HttpContext.Current.Server.MapPath(path);
        }
#else
        /// <summary>
        /// 映射虚拟路径，得到的是wwwroot目录下的路径
        /// </summary>
        /// <param name="path"></param>
        /// <param name="hosting">环境变量，可选</param>
        /// <returns></returns>
        public static string Map(string path, Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting = null)
        {
            var rootPrefix = AppContext.BaseDirectory;
            if (hosting != null)
            {
                rootPrefix = hosting.WebRootPath;
            }
            var rootDir = rootPrefix.Replace('\\', '/').TrimEnd('/') + '/';
            return rootDir + path.TrimStart('/');
        }
#endif
    }
}