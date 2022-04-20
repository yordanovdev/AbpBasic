using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Something.EntityFrameworkCore;
using Something.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Something.Web.Tests
{
    [DependsOn(
        typeof(SomethingWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SomethingWebTestModule : AbpModule
    {
        public SomethingWebTestModule(SomethingEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SomethingWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SomethingWebMvcModule).Assembly);
        }
    }
}