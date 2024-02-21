using Abp.Application.Services;
using Checkpoint.MultiTenancy.Dto;

namespace Checkpoint.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

