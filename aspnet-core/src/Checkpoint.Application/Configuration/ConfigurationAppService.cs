using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Checkpoint.Configuration.Dto;

namespace Checkpoint.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CheckpointAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
