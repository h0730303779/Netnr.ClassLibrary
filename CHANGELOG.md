# 更新日志
### [v1.2.1] - 2019-11-28 (未发布Nuget)
- 调整 `Netnr.Fast` 类库下部分类提取为无命名空间类，放置 `PublicClass` 文件夹下
- 更新 部分注释、语法版本
- 更新 `Extend` 拓展类下 `ToTimestamp` 转时间戳的方法支持 10位 秒 和 13位 毫秒，默认 秒

### [v1.2.1] - 2019-10-11
- 修复 `CmdTo.Shell` 方法
- 添加 `Netnr.Fast.OSInfoTo` 类

### [v1.2.0] - 2019-09-27
- 调整 项目框架为 `.NET Standard 2.1`
- 调整 `CmdTo.Shell` 方法，输出`BashResult`对象，直接集成`Shell.NET`源码去除引用
- 调整 `ClientTo` 类转移到 `Netnr.Fast` , 即删除 `Core.ClientTo`
- 调整 `DownTo` 类转移到 `Netnr.Fast` , 即删除 `Core.DownTo`
- 调整 `ConsoleTo.Log` 方法，支持`object`输出，内部自动转换
- 删除 `MapPathTo` 类

### [v1.1.1] - 2019-06-27
- 添加 `CalcTo` 类，添加 `HMAC_SHA256、384、512` 加密算法
- 调整 `Extend` 拓展类，字符串序列化实体（`ToEntity`、`ToEntitys`）
- 调整 `NpoiTo.cs`，方法合并、导出标题加粗
- 调整 `Netnr.Fast` 项目框架为 `.NET Standard 2.0`

### [v1.1.0] - 2019-04-24
- 修复 `CmdTo.Run` 方法
- 调整 `PingyinTo` 类转移到 `Netnr.Fast` , 即删除 `Core.PingyinTo`

### [v1.0.2] - 2019-03-21
- 添加 NuGet 发布包带注释
- 改进 `HttpTo` 提供的方法
- 调整 `Extend` 拓展方法在 `Netnr` 命名空间下
- 整合 以后所有的 `Netnr.XXX` 项目都引用`Netnr.Core`

### [v1.0.1] - 2019-02-20
- 修复 `MapPathTo.Map` 方法
