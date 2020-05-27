using Abp.Application.Services;
using ABPVue.MultiTenancy.Dto;

namespace ABPVue.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

