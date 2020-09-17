using Abp.Application.Services;
using ABPUnity01.MultiTenancy.Dto;

namespace ABPUnity01.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

