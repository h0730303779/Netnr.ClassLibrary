# Netnr.ClassLibrary
> 公共类库、常用的方法

### [更新日志](CHANGELOG.md)

### 项目
-  **Netnr.Core** 　公共核心的类库（直接使用）
-  **Netnr.Fast** 　常用的的类库（根据自己的实际情况微调，如一些参数）

### 安装（NuGet）
```
Install-Package Netnr.Core
```

### Netnr.Core
- CacheTo.cs　　缓存（Core需要依赖注入，并赋值 `Netnr.Core.memoryCache` 对象）
- CalcTo.cs　　算法、加密、解密（MD5、DES、SHA1、HMAC_SHA1）
- CmdTo.cs　　执行命令，支持Windows、Linux
- ConsoleTo.cs　　输出日志、错误信息
- Extend.cs　　常用方法拓展（依赖 `Newtonsoft.Json`，JSON、实体、编码、SQL等转换）
- FileTo.cs　　读写文件
- HttpTo.cs　　HTTP请求（GET、POST等，可设置 `HttpWebRequest` 对象）
- LamdaTo.cs　　动态生成 Lamda 表达式
- RandomTo.cs　　生成随机码（验证码）
- RsaTo.cs　　RSA加密解密及RSA签名和验证
- TreeTo.cs　　Tree常用方法（List数据集生成JSON tree，菜单多级导航）
- UniqueTo.cs　　生成唯一的标识（GUID转成long）

### Netnr.Fast
- ClientTo.cs　　获取客户端的一些信息（需要传入 `HttpContext`）
- DownTo.cs　　流下载文件（需要传入 `HttpResponse`）
- GlobalTo.cs　　Core环境`IConfiguration` `IHostEnvironment` 对象，`appsettings.json`配置文件
- ImageTo.cs　　图片操作（生成验证码、缩略图、水印）
- NpoiTo.cs　　操作Excel（依赖 `NPOI`，Excel文件与DataTable相互转换，支持 .xls、.xlsx，Framework项目需要引入`SharpZipLib`）
- PaginationVM.cs　　分页参数实体，无命名空间
- PinyinTo.cs　　中文转拼音（NPinyin）
- QueryableTo.cs　　IQueryable对象的拓展，如排序拼接
- RegexTo.cs　　常用正则验证


### 框架
- .NETStandard 2.1
- .NETFramework 4.0

### Source
- <https://github.com/netnr/Netnr.ClassLibrary>
- <https://gitee.com/netnr/Netnr.ClassLibrary>