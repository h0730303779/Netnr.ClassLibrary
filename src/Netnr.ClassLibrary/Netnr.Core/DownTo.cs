#if NET40
using System.IO;
using System.Web;

namespace Netnr.Core
{
    /// <summary>
    /// 下载
    /// </summary>
    public class DownTo
    {
        /// <summary>
        /// 流的方式下载
        /// </summary>
        public static void Stream(string path, string fileName)
        {
            FileStream fileStream = new FileStream(path + fileName, FileMode.Open);
            byte[] bytes = new byte[(int)fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();

            var Response = HttpContext.Current.Response;
            Response.ContentType = "application/octet-stream";

            // 通知浏览器下载而不是打开  
            Response.Headers.Add("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));

            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }
    }
}
#else
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Netnr.Core
{
    /// <summary>
    /// 下载
    /// </summary>
    public class DownTo
    {
        private HttpResponse Response;

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="httpResponse"></param>
        public DownTo(HttpResponse httpResponse)
        {
            Response = httpResponse;
        }

        /// <summary>
        /// 流的方式下载
        /// </summary>
        public void Stream(string path, string fileName)
        {
            FileStream fileStream = new FileStream(path + fileName, FileMode.Open);
            byte[] bytes = new byte[(int)fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();

            Response.ContentType = "application/octet-stream";

            // 通知浏览器下载而不是打开  
            Response.Headers.Add("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
            Response.Body.Write(bytes, 0, bytes.Length);
            Response.Body.Flush();
        }
    }
}
#endif