using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPUnity01.Authorization;

namespace ABPUnity01
{
    [DependsOn(
        typeof(ABPUnity01CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPUnity01ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPUnity01AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPUnity01ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
