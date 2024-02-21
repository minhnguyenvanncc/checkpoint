using System.Threading.Tasks;
using Abp.Application.Services;
using Checkpoint.Authorization.Accounts.Dto;

namespace Checkpoint.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
