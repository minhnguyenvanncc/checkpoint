using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Checkpoint.EntityFrameworkCore;
using Checkpoint.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Checkpoint.Web.Tests
{
    [DependsOn(
        typeof(CheckpointWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CheckpointWebTestModule : AbpModule
    {
        public CheckpointWebTestModule(CheckpointEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CheckpointWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CheckpointWebMvcModule).Assembly);
        }
    }
}