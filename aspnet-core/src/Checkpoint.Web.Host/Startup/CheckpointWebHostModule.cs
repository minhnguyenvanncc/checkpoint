using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Checkpoint.Configuration;

namespace Checkpoint.Web.Host.Startup
{
    [DependsOn(
       typeof(CheckpointWebCoreModule))]
    public class CheckpointWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CheckpointWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CheckpointWebHostModule).GetAssembly());
        }
    }
}
