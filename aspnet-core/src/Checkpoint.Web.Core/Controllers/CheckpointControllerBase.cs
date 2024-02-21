using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Checkpoint.Controllers
{
    public abstract class CheckpointControllerBase: AbpController
    {
        protected CheckpointControllerBase()
        {
            LocalizationSourceName = CheckpointConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
