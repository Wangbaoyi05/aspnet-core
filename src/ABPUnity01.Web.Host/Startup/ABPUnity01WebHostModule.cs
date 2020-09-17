using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPUnity01.Configuration;

namespace ABPUnity01.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPUnity01WebCoreModule))]
    public class ABPUnity01WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPUnity01WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPUnity01WebHostModule).GetAssembly());
        }
    }
}
