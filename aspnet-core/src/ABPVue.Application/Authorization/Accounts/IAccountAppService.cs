using System.Threading.Tasks;
using Abp.Application.Services;
using ABPVue.Authorization.Accounts.Dto;

namespace ABPVue.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
