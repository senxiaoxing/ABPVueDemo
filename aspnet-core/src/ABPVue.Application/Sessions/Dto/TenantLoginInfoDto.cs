using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABPVue.MultiTenancy;

namespace ABPVue.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
