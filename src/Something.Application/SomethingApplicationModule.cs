using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Something.Authorization;

namespace Something
{
    [DependsOn(
        typeof(SomethingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SomethingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SomethingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SomethingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
