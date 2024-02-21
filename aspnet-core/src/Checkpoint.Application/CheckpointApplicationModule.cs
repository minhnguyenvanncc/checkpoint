using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Checkpoint.Authorization;

namespace Checkpoint
{
    [DependsOn(
        typeof(CheckpointCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CheckpointApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CheckpointAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CheckpointApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
