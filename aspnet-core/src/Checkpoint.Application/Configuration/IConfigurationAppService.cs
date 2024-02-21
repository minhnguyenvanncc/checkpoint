using System.Threading.Tasks;
using Checkpoint.Configuration.Dto;

namespace Checkpoint.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
