using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPUnity01.EntityFrameworkCore;
using ABPUnity01.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ABPUnity01.Web.Tests
{
    [DependsOn(
        typeof(ABPUnity01WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABPUnity01WebTestModule : AbpModule
    {
        public ABPUnity01WebTestModule(ABPUnity01EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPUnity01WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABPUnity01WebMvcModule).Assembly);
        }
    }
}