using System.Threading.Tasks;
using Abp.Application.Services;
using Checkpoint.Sessions.Dto;

namespace Checkpoint.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
