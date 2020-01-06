/*
*┌────────────────────────────────────────────────┐
*│　描   述：读取Appsettings                                                    
*│　作   者：lc                                              
*│　版   本：1.0                                              
*│　创建时间：2019-12-05 16:17:01                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBill.Common
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Configuration.Json;
    /// <summary>
    /// 读取appsetting.json
    /// //调用
    /// AppConfigurtaionServices.Configuration.GetConnectionString("conn");
    /// //读取一级
    /// AppConfigurtaionServices.Configuration["str"];
    /// //读取二级
    /// AppConfigurtaionServices.Configuration["Path:LogsPath"];
    /// //注意，如果AppConfigurtaionServices类中抛出FileNotFoundException异常，说明目录下未找到appsettings.json文件，这时请在项目appsettings.json文件上右键——属性——将“复制到输出目录”项的值改为“如果较新则复制”即可。
    /// </summary>
    public class AppConfigurtaionServices
    {
        public static IConfiguration Configuration { get; set; }
        static AppConfigurtaionServices()
        {
            //ReloadOnChange = true 当appsettings.json被修改时重新加载            
            Configuration = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
            .Build();
        }
    }
}
